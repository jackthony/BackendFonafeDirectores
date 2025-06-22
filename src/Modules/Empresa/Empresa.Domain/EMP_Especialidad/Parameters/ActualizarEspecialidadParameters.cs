
namespace Empresa.Domain.Especialidad.Parameters
{
    public class ActualizarEspecialidadParameters
    {
        public int EspecialidadId { get; set; }
        public string NombreEspecialidad { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
        public DateTime FechaModificacion { get; set; }

    }
}
