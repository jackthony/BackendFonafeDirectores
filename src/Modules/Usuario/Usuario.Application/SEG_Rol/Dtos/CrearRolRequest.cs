namespace Usuario.Application.Rol.Dtos
{
    public class CrearRolRequest
    {
        public string Rolname { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string CorreoElectronico { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public string ApellidoPaterno { get; set; } = default!;
        public string ApellidoMaterno { get; set; } = default!;
        public string Nombres { get; set; } = default!;
    }
}
