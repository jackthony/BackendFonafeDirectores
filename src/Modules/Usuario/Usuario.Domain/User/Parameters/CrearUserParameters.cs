namespace Usuario.Domain.User.Parameters
{
    public class CrearUserParameters
    {
        // Tabla SEG_Usuario
        public string Username { get; set; } = default!;
        public string PasswordHash { get; set; } = default!;
        public string CorreoElectronico { get; set; } = default!;
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }

        // Tabla SEG_UsuarioInfo
        public string ApellidoPaterno { get; set; } = default!;
        public string ApellidoMaterno { get; set; } = default!;
        public string Nombres { get; set; } = default!;
    }
}
