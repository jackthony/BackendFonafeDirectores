/***********
 * Nombre del archivo:  UsuarioLogueadoDto.cs
 * Descripción:         DTO que representa la información del usuario autenticado,
 *                      incluyendo su ID, correo electrónico y tokens de acceso.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del DTO para respuestas de login.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class UsuarioLogueadoDto
    {
        public int UsuarioId { get; set; }
        public string Correo { get; set; } = default!;
        public string AccessToken { get; set; } = default!;
        public string RefreshToken { get; set; } = default!;
    }
}
