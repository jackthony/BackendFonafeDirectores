using System;
using System.Collections.Generic;
using System.Linq;
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
            // 1. Validar CAPTCHA
            if (!await _captchaService.ValidateCaptchaAsync(request.CaptchaResponse))
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
