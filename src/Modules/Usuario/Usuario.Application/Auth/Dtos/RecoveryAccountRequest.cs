/***********
 * Nombre del archivo:  RecoveryAccountRequest.cs
 * Descripción:         DTO para solicitar la recuperación de una cuenta de usuario.
 *                      Contiene el correo, el nombre del solicitante y un comentario opcional.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Estructura base para la funcionalidad de recuperación de cuenta.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class RecoveryAccountRequest
    {
        public required string sCorreo {  get; set; }
        public required string sNombre { get; set; }
        public required string sComentario { get; set; } = string.Empty;
    }
}
