namespace Usuario.Application.Auth.Dtos
{
    public class RefreshTokenCreateRequest
    {
        public int UsuarioId { get; set; }
        public string Token { get; set; } = string.Empty;
    }
}
