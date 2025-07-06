using Shared.Kernel.Interfaces;
using Usuario.Domain.Auth.Results;
using Usuario.Domain.SEG_Modulo.Models;

namespace Usuario.Application.Auth.Dtos
{
    public class LoginResponse : IAuditableResponse
    {
        public UsuarioResult UsuarioResult { get; set; } = default!;
        public List<ModuloPermiso> Modulos { get; set; } = [];
        public string AccessToken { get; set; } = default!;
        public string RefreshToken { get; set; } = default!;

        public int? UsuarioId => UsuarioResult.UsuarioId;
        public string? DetallesAuditoria => $"Login exitoso para usuario ID {UsuarioResult.UsuarioId}";

    }
}
