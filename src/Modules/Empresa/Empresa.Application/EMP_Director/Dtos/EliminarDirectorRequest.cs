namespace Empresa.Application.Director.Dtos
{
    public class EliminarDirectorRequest
    {
        public int nDirectorId { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
