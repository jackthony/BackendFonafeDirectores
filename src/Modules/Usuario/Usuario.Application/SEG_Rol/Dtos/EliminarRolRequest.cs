namespace Usuario.Application.Rol.Dtos
{
    public class EliminarRolRequest
    {
        public int nRolId { get; set; }
        public int nIdUsuarioModificacion { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
