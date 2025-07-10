/***********
* Nombre del archivo: VerifyTokenUseCase.cs
* Descripción:        **Caso de uso** para la verificación de un token de acceso (JWT).
*                     Orquesta el proceso de validar un token de acceso, extrayendo la información del usuario
*                     contenida en el token y confirmando su validez y estado en la base de datos.
*                     Si el token es válido y el usuario está activo, construye una respuesta de login
*                     con el token, los módulos y permisos asociados, y los datos del usuario.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para la verificación de tokens.
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using System.Security.Claims;
using System.Text.Json;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Repositories;
using Usuario.Domain.SEG_Modulo.Models;

namespace Usuario.Application.Auth.UseCases
{
    public class VerifyTokenUseCase : IUseCase<VerifyTokenRequest, LoginResponse>
    {
        private readonly ITokenService _tokenService;
        private readonly IAuthRepository _authRepository;

        public VerifyTokenUseCase(ITokenService tokenService, IAuthRepository authRepository)
        {
            _tokenService = tokenService;
            _authRepository = authRepository;
        }

        public async Task<OneOf<ErrorBase, LoginResponse>> ExecuteAsync(VerifyTokenRequest request)
        {
            var claimsPrincipal = _tokenService.ValidateAccessToken(request.Token);

            if (claimsPrincipal == null)
                return ErrorBase.Validation("Token inválido o expirado");

            var userCodeClaim = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier);

            if (userCodeClaim == null || string.IsNullOrWhiteSpace(userCodeClaim.Value))
                return ErrorBase.Validation("El token no contiene información del usuario");

            if (!int.TryParse(userCodeClaim.Value, out var userId))
                return ErrorBase.Validation("Formato de ID de usuario inválido en el token");

            var result = await _authRepository.ObtenerPorIdAsync(userId);

            if (!result.Success || result.Data is null)
                return ErrorBase.Database(result.Message);

            var usuario = result.Data;
            // Verificar que el usuario es el que hace la solicitud
            if (userId != usuario.UsuarioId)
                return ErrorBase.Validation("El token no pertenece a este usuario.");

            if (usuario.Status != "1")
                return ErrorBase.Validation("El usuario no se encuentra activo");

            var modulosPermisos = JsonSerializer.Deserialize<List<ModuloPermiso>>(usuario.JsonModulos) ?? [];
            usuario.PasswordHash = "";
            return new LoginResponse
            {
                AccessToken = request.Token,
                Modulos = modulosPermisos,
                UsuarioResult = usuario
            };
        }
    }
}
