namespace Usuario.Application.Rol.Dtos
{
    public class EliminarRolRequest
    {
        public int nCargoId { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
