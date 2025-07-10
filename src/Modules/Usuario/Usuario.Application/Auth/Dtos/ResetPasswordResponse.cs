/***********
 * Nombre del archivo:  ResetPasswordResponse.cs
 * Descripción:         DTO de respuesta para operaciones de restablecimiento de contraseña.
 *                      Indica si la operación fue exitosa y proporciona un mensaje descriptivo.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial de estructura de respuesta para reset de contraseña.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class ResetPasswordResponse
    {
        public bool isSuccess { get; set; }  // Indica si la operación fue exitosa (true) o fallida (false)
        public string Message { get; set; } = default!;  // Mensaje que explica el resultado (éxito o error)
    }
}
