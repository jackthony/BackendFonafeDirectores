namespace Usuario.Application.PermisoRol.Dtos
{
    public class EliminarPermisoRolRequest
    {
        public int nRolId { get; set; }
        public int nModuloId { get; set; }
        public int nAccionId { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
