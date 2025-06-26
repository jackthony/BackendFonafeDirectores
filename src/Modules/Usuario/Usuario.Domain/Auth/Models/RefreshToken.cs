namespace Usuario.Domain.Auth.Models
{
    public class RefreshToken
    {
        public long RefreshTokenId { get; set; }
        public int UsuarioId { get; set; }
        public string Token { get; set; } = string.Empty;
        public DateTime Expiracion { get; set; }
        public DateTime Creacion { get; set; }
        public bool Revocado { get; set; }
        public string? IpRegistro { get; set; }
    }
}
