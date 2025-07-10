/***********
* Nombre del archivo: ForgotPasswordUseCase.cs
* Descripción:        **Caso de uso** para el proceso de "Olvidé mi contraseña".
*                     Orquesta la validación de un **captcha**, la búsqueda de un usuario por su correo electrónico
*                     en el **repositorio de autenticación**, la generación de un **token de restablecimiento de contraseña**,
*                     y el envío de un correo electrónico con un enlace para restablecer la contraseña a la dirección
*                     del usuario.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase de caso de uso para la funcionalidad de "Olvidé mi contraseña".
***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Repositories;

namespace Usuario.Application.Auth.UseCases
{
    public class ForgotPasswordUseCase : IUseCase<ForgotPasswordRequest, ForgotPasswordResponse>
    {
        private readonly IAuthRepository _authRepository;
        private readonly IEmailService _emailService;
        private readonly ICaptchaService _captchaService;
        private readonly ITokenService _tokenService;

        public ForgotPasswordUseCase(
            IAuthRepository authRepository,
            IEmailService emailService,
            ICaptchaService captchaService,
            ITokenService tokenService)
        {
            _authRepository = authRepository;
            _emailService = emailService;
            _captchaService = captchaService;
            _tokenService = tokenService;
        }

        public async Task<OneOf<ErrorBase, ForgotPasswordResponse>> ExecuteAsync(ForgotPasswordRequest request)
        {
            //Validacion Capcha
            if (string.IsNullOrWhiteSpace(request.captchaResponse))
                return ErrorBase.Validation("Captcha es requerido");
            if (!await _captchaService.ValidateCaptchaAsync(request.captchaResponse))
                return ErrorBase.Validation("Captcha inválido o expirado");


            var parameters = new LoginParameters{Correo = request.Email};
            // 2. Buscar al usuario por correo electrónico
            var userResult = await _authRepository.ObtenerPorCorreoAsync(parameters);

            if (!userResult.Success || userResult.Data is null)
                return ErrorBase.Validation("Correo electrónico no registrado");

            var usuario = userResult.Data;

            // 3. Generar token de restablecimiento
            var resetToken = _tokenService.GenerateResetPasswordToken(usuario.UsuarioId);

            // 4. Enviar correo con el link de restablecimiento
            var resetLink = $"https://fonafe-directores.com/reset-password?token={resetToken}";
            await _emailService.SendPasswordResetEmailAsync(usuario.CorreoElectronico, resetLink);

            // 5. Registrar la solicitud en auditoría (si lo deseas)
            // await _auditService.LogPasswordResetRequestAsync(usuario.UsuarioId);

            return new ForgotPasswordResponse
            {
                Success = true,
                Message = "Se ha enviado un enlace para restablecer tu contraseña a tu correo."
            };
        }
    }

}
