using Usuario.Domain.Auth.Results;

namespace Usuario.Application.Auth.Dtos
{
    public class LoginResponse
    {
        public UsuarioResult UsuarioResult { get; set; } = default!;
        public string AccessToken { get; set; } = default!;
        public string RefreshToken { get; set; } = default!;
    }
}
