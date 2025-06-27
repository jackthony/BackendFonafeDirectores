namespace Empresa.Domain.Director.Parameters
{
    public class EliminarDirectorParameters
    {
        public int nDirectorId { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
