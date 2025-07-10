/***********
 * Nombre del archivo:  AdminResetPasswordRequest.cs
 * Descripción:         DTO que representa la solicitud para que un administrador restablezca la contraseña de un usuario.
 *                      Incluye el ID del usuario objetivo, la nueva contraseña y un token de autenticación del administrador.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del modelo de solicitud para reinicio de contraseña por administrador.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class AdminResetPasswordRequest
    {
        public required int UsuarioId { get; set; }   // ID del usuario cuya contraseña será restablecida
        public required string NewPassword { get; set; }  // Nueva contraseña
        public required string Token { get; set; }     // Token del administrador (usado para verificar permisos)
    }
}
