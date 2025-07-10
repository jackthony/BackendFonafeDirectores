/***********
 * Nombre del archivo:  ForgotPasswordRequest.cs
 * Descripción:         DTO utilizado para iniciar el proceso de recuperación de contraseña.
 *                      Contiene el correo del usuario y la respuesta del CAPTCHA para validación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del modelo de solicitud para recuperación de contraseña.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class ForgotPasswordRequest
    {
        public required string Email { get; set; }  // Correo electrónico del usuario
        public required string captchaResponse { get; set; }  // Respuesta del CAPTCHA
    }
}
