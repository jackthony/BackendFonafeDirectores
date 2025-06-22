namespace Empresa.Application.Especialidad.Dtos
{
    public class ActualizarEspecialidadRequest
    {
        public int EspecialidadId { get; set; }
        public string NombreEspecialidad { get; set; } = default!;
        public int UsuarioModificacionId { get; set; }
    }
}
