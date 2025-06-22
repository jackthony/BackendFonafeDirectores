namespace Usuario.Domain.Rol.Parameters
{
    public class CrearRolParameters
    {
        // Tabla SEG_Usuario
        public string Rolname { get; set; } = default!;
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
