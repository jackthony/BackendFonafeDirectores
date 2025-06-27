using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Application.Auth.Dtos
{
    public class ForgotPasswordRequest
    {
        public required string Email { get; set; }  // Correo electrónico del usuario
        public required string CaptchaResponse { get; set; }  // Respuesta del CAPTCHA
    }
}
