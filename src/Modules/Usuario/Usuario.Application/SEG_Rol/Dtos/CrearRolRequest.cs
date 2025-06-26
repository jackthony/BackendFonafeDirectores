namespace Usuario.Application.Rol.Dtos
{
    public class CrearRolRequest
    {
        public string sNombreRol { get; set; } = default!;
        public int nUsuarioRegistro { get; set; }
        public DateTime dtFechaRegistro { get; set; }
    }
}