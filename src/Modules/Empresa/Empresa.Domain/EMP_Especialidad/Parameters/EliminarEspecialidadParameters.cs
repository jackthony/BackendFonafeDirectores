
namespace Empresa.Domain.Especialidad.Parameters
{
    public class EliminarEspecialidadParameters
    {
        public int EspecialidadId { get; set; }
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
