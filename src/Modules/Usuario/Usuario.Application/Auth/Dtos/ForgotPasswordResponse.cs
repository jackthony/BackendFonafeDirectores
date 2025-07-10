/***********
 * Nombre del archivo:  ForgotPasswordResponse.cs
 * Descripción:         DTO de respuesta utilizado en el flujo de recuperación de contraseña.
 *                      Informa si el proceso fue exitoso y proporciona un mensaje descriptivo.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del modelo de respuesta para recuperación de contraseña.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class ForgotPasswordResponse
    {
        public bool Success { get; set; }  // Indica si la operación fue exitosa
        public string Message { get; set; } = default!;  // Mensaje de respuesta
    }
}

