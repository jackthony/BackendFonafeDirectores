namespace Usuario.Application.User.Dtos
{
    public class CrearUserRequest
    {
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string CorreoElectronico { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public string ApellidoPaterno { get; set; } = default!;
        public string ApellidoMaterno { get; set; } = default!;
        public string Nombres { get; set; } = default!;
    }
}
