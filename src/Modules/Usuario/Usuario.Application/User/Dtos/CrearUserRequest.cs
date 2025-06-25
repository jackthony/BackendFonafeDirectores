namespace Usuario.Application.User.Dtos
{
    public class CrearUserRequest
    {
        public required string sContrasena { get; set; } = default!;
        public required string sCorreoElectronico { get; set; } = default!;
        public required int nUsuarioRegistro { get; set; }
        public required string sApellidoPaterno { get; set; }
        public required string sApellidoMaterno { get; set; }
        public required string sNombres { get; set; }
        public int nIdCargo { get; set; }
        public int nIdRol {  get; set; }
        public int nEstado { get; set; }
    }
}
