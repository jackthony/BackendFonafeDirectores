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
