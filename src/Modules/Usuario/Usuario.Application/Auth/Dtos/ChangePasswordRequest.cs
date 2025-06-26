using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Application.Auth.Dtos
{
    public class ChangePasswordRequest
    {
        public int UsuarioId { get; set; }               // ID del usuario
        public string PasswordActual { get; set; }       // Contraseña actual del usuario
        public string PasswordNueva { get; set; }        // Nueva contraseña
        public string CaptchaResponse { get; set; }      // Respuesta del CAPTCHA (verificada en el backend)
        public string? Token { get; set; }                // Token de verificación (si se utiliza)
    }

}
