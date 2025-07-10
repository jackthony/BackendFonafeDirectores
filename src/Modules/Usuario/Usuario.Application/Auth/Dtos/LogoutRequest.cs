/***********
 * Nombre del archivo:  LogoutRequest.cs
 * Descripción:         DTO utilizado para solicitar el cierre de sesión del usuario.
 *                      Contiene el refresh token que será revocado del sistema.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Definición inicial del objeto de solicitud para el logout.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class LogoutRequest
    {
        public string Token { get; set; } = string.Empty;
    }
}
