using Shared.Kernel.Interfaces;

namespace Usuario.Application.Auth.Dtos
{
    public class VerifyTokenRequest : ISistemaRequest
    {
        public string Token { get; set; } = string.Empty;

        public int? UsuarioId => null;
        public string? Origen => "Auth";
        public int? Estado => 1;
        public string? Mensaje => "Cerrar sesión";
        public string? TipoEvento => "Logout";
    }
}
