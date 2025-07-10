/***********
 * Nombre del archivo:  RefreshTokenCreateRequest.cs
 * Descripción:         DTO para registrar un nuevo refresh token en el sistema.
 *                      Contiene el ID del usuario y el token generado.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Estructura básica para persistencia del refresh token asociado a un usuario.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class RefreshTokenCreateRequest
    {
        public int UsuarioId { get; set; }
        public string Token { get; set; } = string.Empty;
    }
}
