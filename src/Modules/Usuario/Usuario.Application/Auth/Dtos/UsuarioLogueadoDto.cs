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
