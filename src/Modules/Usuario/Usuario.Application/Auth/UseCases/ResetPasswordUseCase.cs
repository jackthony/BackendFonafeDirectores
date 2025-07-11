/***********
* Nombre del archivo: ResetPasswordUseCase.cs
* Descripción:        **Caso de uso** para restablecer la contraseña de un usuario utilizando un token de restablecimiento.
*                     Orquesta el proceso de validación del captcha, verificación del token de restablecimiento,
*                     búsqueda del usuario asociado, hashing de la nueva contraseña y actualización de la misma
*                     en el repositorio de autenticación.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para restablecer la contraseña.
***********/

using System.Security.Claims;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Time;
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
        private readonly ITimeProvider _timeProvider;

        public ResetPasswordUseCase(ITokenService tokenService, IAuthRepository authRepository, IPasswordHasher passwordHasher, ICaptchaService captchaService, ITimeProvider timeProvider)
        {
            _tokenService = tokenService;
            _authRepository = authRepository;
            _passwordHasher = passwordHasher;
            _captchaService = captchaService;
            _timeProvider = timeProvider;
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
                return ErrorBase.Validation("Enlace expirado");

            // 2) Obtener usuario a partir del token (usualmente almacenado en el JWT)
            var userId = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId) || !int.TryParse(userId, out var usuarioId))
                return ErrorBase.Validation("Enlace inválido.");

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
                newPasswordHash = newHash,
                FechaModifica = _timeProvider.NowPeru
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
