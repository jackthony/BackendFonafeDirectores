/***********
 * Nombre del archivo:  TokenDto.cs
 * Descripción:         DTO que encapsula los tokens de autenticación generados
 *                      durante el proceso de login o renovación de sesión.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del DTO para manejo de tokens.
 ***********/

namespace Usuario.Application.Auth.Dtos
{
    public class TokenDto
    {
        public string AccessToken { get; set; } = default!;
        public string RefreshToken { get; set; } = default!;
    }
}
