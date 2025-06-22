namespace Empresa.Domain.TipoDirector.Parameters
{
    public class EliminarTipoDirectorParameters
    {
        public int TipoDirectorId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
