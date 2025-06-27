namespace Usuario.Domain.PermisoRol.Parameters
{
    public class CrearPermisoRolParameters
    {
        public int nRolId { get; set; }
        public int nModuloId { get; set; }
        public int nAccionId { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime dtFechaRegistro { get; set; }
    }
}
