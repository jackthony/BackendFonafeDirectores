/***********
 * Nombre del archivo:  LoginRequest.cs
 * Descripción:         DTO utilizado para enviar las credenciales del usuario en el proceso de autenticación.
 *                      Incluye integración con trazabilidad del sistema mediante la interfaz ISistemaRequest.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Inclusión de campos para trazabilidad y validación de captcha.
 ***********/

using Shared.Kernel.Interfaces;

namespace Usuario.Application.Auth.Dtos
{
    public class LoginRequest : ISistemaRequest
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string captchaResponse { get; set; }

        public int? UsuarioId => null;
        public string? Origen => "Auth";
        public int? Estado => 1;
        public string? Mensaje => "Intento de incio de sesión";
        public string? TipoEvento => "Login";
    }
}
