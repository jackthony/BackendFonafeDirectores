using Shared.Kernel.Interfaces;

namespace Usuario.Application.Auth.Dtos
{
    public class LoginRequest : IAuditableRequest
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string captchaResponse { get; set; }

        public int? UsuarioId => null;
        public string AccionAuditable => "Login";
        public string? DetallesAuditoria => $"Intento de login con email: {Email}";
    }
}
