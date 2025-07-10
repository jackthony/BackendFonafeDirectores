/***********
 * Nombre del archivo:  RefreshTokenRequest.cs
 * Descripción:         DTO para la solicitud de renovación de tokens JWT.
 *                      Contiene el access token y el refresh token proporcionados por el cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial de estructura para renovación de sesión.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class RefreshTokenRequest
    {
        public required string sAccessToken { get; set; }
        public required string sRefreshToken { get; set; }
    }
}
