﻿/***********
* Nombre del archivo: LoginUseCase.cs
* Descripción:        **Caso de uso** para el proceso de inicio de sesión de un usuario.
*                     Orquesta la validación del captcha, la recuperación de la información del usuario
*                     desde el **repositorio** basada en el correo electrónico, la verificación de la contraseña,
*                     la gestión de intentos fallidos de login (incluyendo el bloqueo de la cuenta),
*                     la generación de tokens de acceso y de refresco, y el almacenamiento del token de refresco.
*                     Finalmente, construye una respuesta de login con el token de acceso, los módulos
*                     y permisos del usuario, y el token de refresco.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para el proceso de login.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using System.Text.Json;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Models;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Repositories;
using Usuario.Domain.Rol.Results;
using Usuario.Domain.SEG_Modulo.Models;

namespace Usuario.Application.Auth.UseCases
{
    public class LoginUseCase : IUseCase<LoginRequest, LoginResponse>
    {
        private readonly IAuthRepository _authRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ITokenService _tokenService;
        private readonly ICaptchaService _captchaService;
        private readonly IMapper<LoginRequest, LoginParameters> _mapper;
        private readonly IMapper<RefreshTokenCreateRequest, RefreshToken> _mapperRefreshToken;

        public LoginUseCase(IAuthRepository authRepository, IPasswordHasher passwordHasher, ITokenService tokenService, ICaptchaService captchaService, IMapper<LoginRequest, LoginParameters> mapper, IMapper<RefreshTokenCreateRequest, RefreshToken> mapperRefreshToken)
        {
            _authRepository = authRepository;
            _passwordHasher = passwordHasher;
            _tokenService = tokenService;
            _captchaService = captchaService;
            _mapper = mapper;
            _mapperRefreshToken = mapperRefreshToken;
        }

        public async Task<OneOf<ErrorBase, LoginResponse>> ExecuteAsync(LoginRequest request)
        {
            //Validacion Capcha
            if (string.IsNullOrWhiteSpace(request.captchaResponse))
                return ErrorBase.Validation("Captcha es requerido");
            if (!await _captchaService.ValidateCaptchaAsync(request.captchaResponse))
                return ErrorBase.Validation("Captcha inválido o expirado");

            var parameters = _mapper.Map(request);

            var result = await _authRepository.ObtenerPorCorreoAsync(parameters);

            if (!result.Success || result.Data is null)
                return ErrorBase.Database(result.Message);

            var usuario = result.Data;

            var isPasswordValid = _passwordHasher.Verify(request.Password, usuario.PasswordHash);
            if (!isPasswordValid)
            {
                if (usuario.IntentosFallidos < 3)
                {
                    await _authRepository.IncrementarIntentosFallidosAsync(usuario.UsuarioId);
                }
                if (usuario.IntentosFallidos >= 2)
                {
                    return ErrorBase.Validation("Clave incorrecta, 'Su cuenta se bloqueo");
                }
                else
                {
                    return ErrorBase.Validation($"Clave incorrecta, intento {usuario.IntentosFallidos + 1} de 3");
                }
            }

            var modulosPermisos = JsonSerializer.Deserialize<List<ModuloPermiso>>(usuario.JsonModulos) ?? [];

            List<RolResult> roles = JsonSerializer.Deserialize<List<RolResult>>(usuario.JsonRoles) ?? [];

            List<string> nombresRoles = roles.Select(r => r.NombreRol).ToList();

            var sessionId = Guid.NewGuid().ToString();
            var token = _tokenService.GenerateAccessToken(usuario.UsuarioId, usuario.CorreoElectronico, nombresRoles, sessionId);
            //token de refresco que se almacenará en bd
            var refreshToken = _tokenService.GenerateRefreshToken();
            var refreshTokenRequest = new RefreshTokenCreateRequest { Token = refreshToken , UsuarioId = usuario.UsuarioId };
            var refreshMapper = _mapperRefreshToken.Map(refreshTokenRequest);

            await _authRepository.GuardarRefreshToken(refreshMapper);

            usuario.PasswordHash = "";
            return new LoginResponse
            {
                AccessToken = token,
                Modulos = modulosPermisos,
                UsuarioResult = usuario,
                RefreshToken = refreshToken,
                SessionId = sessionId
            };
        }

    }
}
