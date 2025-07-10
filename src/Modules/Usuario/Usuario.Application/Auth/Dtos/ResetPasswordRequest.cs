/***********
 * Nombre del archivo:  ResetPasswordRequest.cs
 * Descripción:         DTO de solicitud para el restablecimiento de contraseña.
 *                      Contiene el token recibido, la nueva contraseña y la validación CAPTCHA.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del DTO para manejar solicitudes de cambio de contraseña vía token.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class ResetPasswordRequest
    {
        public required string Token { get; set; }        // Token de restablecimiento recibido en el enlace del correo
        public required string NewPassword { get; set; }   // Nueva contraseña proporcionada por el usuario
        public required string captchaResponse { get; set; }  // Respuesta del CAPTCHA para validar la solicitud
    }
}
