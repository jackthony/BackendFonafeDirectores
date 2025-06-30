using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Application.Auth.Dtos
{
    public class ResetPasswordRequest
    {
        public required string Token { get; set; }        // Token de restablecimiento recibido en el enlace del correo
        public required string NewPassword { get; set; }   // Nueva contraseña proporcionada por el usuario
        public required string captchaResponse { get; set; }  // Respuesta del CAPTCHA para validar la solicitud
    }
}
