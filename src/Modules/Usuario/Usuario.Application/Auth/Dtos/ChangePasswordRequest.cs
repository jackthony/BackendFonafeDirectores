/***********
 * Nombre del archivo:  ChangePasswordRequest.cs
 * Descripción:         DTO que representa la solicitud para cambiar la contraseña de un usuario.
 *                      Contiene la contraseña actual, la nueva, un token opcional y la respuesta CAPTCHA.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del modelo de solicitud para cambio de contraseña.
 ***********/

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
