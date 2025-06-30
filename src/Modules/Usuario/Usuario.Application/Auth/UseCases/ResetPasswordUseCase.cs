using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Repositories;

namespace Usuario.Application.Auth.UseCases
{
    public class ResetPasswordUseCase : IUseCase<ResetPasswordRequest, ResetPasswordResponse>
    {
        private readonly ITokenService _tokenService;
        private readonly IAuthRepository _authRepository;
        private readonly IPasswordHasher _passwordHasher;
        private readonly ICaptchaService _captchaService;


        public ResetPasswordUseCase(
            ITokenService tokenService,
            IAuthRepository authRepository,
            IPasswordHasher passwordHasher,
            ICaptchaService captchaService)
        {
            _tokenService = tokenService;
            _authRepository = authRepository;
            _passwordHasher = passwordHasher;
            _captchaService = captchaService;
        }

        public async Task<OneOf<ErrorBase, ResetPasswordResponse>> ExecuteAsync(ResetPasswordRequest request)
        {
            //Validacion Capcha
            if (string.IsNullOrWhiteSpace(request.captchaResponse))
                return ErrorBase.Validation("Captcha es requerido");
            if (!await _captchaService.ValidateCaptchaAsync(request.captchaResponse))
                return ErrorBase.Validation("Captcha inválido o expirado");

            // 1) Validar token de restablecimiento
            var claimsPrincipal = _tokenService.ValidateAccessToken(request.Token);
            if (claimsPrincipal == null)
                return ErrorBase.Validation("Token inválido o expirado");

            // 2) Obtener usuario a partir del token (usualmente almacenado en el JWT)
            var userId = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId) || !int.TryParse(userId, out var usuarioId))
                return ErrorBase.Validation("Token inválido.");

            // 3) Buscar usuario por ID
            var result = await _authRepository.ObtenerPorIdAsync(usuarioId);
            if (!result.Success || result.Data is null)
                return ErrorBase.Validation("El usuario no existe.");

            var usuario = result.Data;

            // 4) Hashear la nueva
            var newHash = _passwordHasher.Hash(request.NewPassword);
            var parameters = new ChangePasswordParameters
            {
                UsuarioId = usuario.UsuarioId,
                newPasswordHash = newHash
            };

            // 5) Actualizar la contraseña en la base de datos
            var updateResult = await _authRepository.UpdatePasswordAsync(parameters);
            if (!updateResult.Success)
                return ErrorBase.Database("No se pudo actualizar la contraseña.");

            // 6) Devolver la respuesta de éxito
            return new ResetPasswordResponse
            {
                isSuccess = true,
                Message = "Contraseña restablecida con éxito."
            };
        }
    }

}
