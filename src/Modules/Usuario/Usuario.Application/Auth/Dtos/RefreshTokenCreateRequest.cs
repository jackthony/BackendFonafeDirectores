/***********
 * Nombre del archivo:  RefreshTokenCreateRequest.cs
 * Descripción:         DTO para registrar un nuevo refresh token en el sistema.
 *                      Contiene el ID del usuario y el token generado.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
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
