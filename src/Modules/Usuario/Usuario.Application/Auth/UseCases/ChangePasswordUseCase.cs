using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Repositories;

namespace Usuario.Application.Auth.UseCases
{
    public class ChangePasswordUseCase: IUseCase<ChangePasswordRequest, SpResultBase>
    {
        private readonly ITokenService _tokenService;
        private readonly IAuthRepository _authRepository;
        private readonly ICaptchaService _captchaService;
        private readonly IPasswordHasher _passwordHasher;

        public ChangePasswordUseCase(ITokenService tokenService, 
            IAuthRepository authRepository,
            ICaptchaService captchaService, 
            IPasswordHasher passwordHasher)
        {
            _tokenService = tokenService;
            _authRepository = authRepository;
            _captchaService = captchaService;
            _passwordHasher = passwordHasher;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(ChangePasswordRequest request)
        {
            // 1) Validar CAPTCHA
            if (!await _captchaService.ValidateCaptchaAsync(request.CaptchaResponse))
                return ErrorBase.Validation("Captcha inválido o expirado");

            // 2) Validar token y extraer userId
            var claimsPrincipal = _tokenService.ValidateAccessToken(request.Token!);

            if (claimsPrincipal == null)
                return ErrorBase.Validation("Token inválido o expirado");

            var userCodeClaim = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier);

            if (userCodeClaim == null || string.IsNullOrWhiteSpace(userCodeClaim.Value))
                return ErrorBase.Validation("El token no contiene información del usuario");

            if (!int.TryParse(userCodeClaim.Value, out var tokenUserId))
                return ErrorBase.Validation("Formato de ID de usuario inválido en el token");

            // Verificar que el usuario es el que hace la solicitud
            if (tokenUserId != request.UsuarioId)
                return ErrorBase.Validation("No tienes permiso para cambiar esta contraseña");

            // 4) Obtener usuario
            var result = await _authRepository.ObtenerPorIdAsync(tokenUserId);

            if (!result.Success || result.Data is null)
                return ErrorBase.Database(result.Message);

            var usuario = result.Data;

            if (usuario.Status != "1")
                return ErrorBase.Validation("El usuario no se encuentra activo");

            // 5) Verificar contraseña actual
            if (!_passwordHasher.Verify(request.PasswordActual, usuario.PasswordHash))
                return ErrorBase.Validation("La contraseña actual es incorrecta");

            // 6) Hashear la nueva
            var newHash = _passwordHasher.Hash(request.PasswordNueva);
            var parameters = new ChangePasswordParameters
            {
                UsuarioId = request.UsuarioId,
                newPasswordHash = newHash
            };

            // 6) Actualizar la contraseña
            var updResult = await _authRepository.UpdatePasswordAsync(parameters);
            if (!updResult.Success)
                return ErrorBase.Database(updResult.Message);

            // 7) Resetear contador de intentos fallidos
            var clearParameters = new ClearFailedAttemptsParameters { UsuarioId = usuario.UsuarioId };

            var resultClear = await _authRepository.ClearFailedAttemptsAsync(clearParameters);

            if (!resultClear.Success)
                return ErrorBase.Database(resultClear.Message);

            // 8) Registrar auditoría mínima (si tu repositorio lo soporta)
            // await _authRepository.LogPasswordChangeAsync(
            //     request.UsuarioId,
            //     claimsPrincipal.FindFirst(ClaimTypes.Name)?.Value ?? "system");

            // 9) Devolver respuesta
            return new SpResultBase
            {
                Success = result.Success,
                Message = result.Message
            };
        }
    }
}
