/***********
 * Nombre del archivo:  AdminResetPasswordResponse.cs
 * Descripción:         DTO que representa la respuesta tras el reinicio de contraseña por parte de un administrador.
 *                      Indica si la operación fue exitosa y un mensaje asociado al resultado.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del modelo de respuesta para reinicio de contraseña administrativa.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class AdminResetPasswordResponse
    {
        public bool isSuccess { get; set; }
        public string Message { get; set; } = default!;
    }
}
