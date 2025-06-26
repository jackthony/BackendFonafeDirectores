namespace Empresa.Application.Especialidad.Dtos
{
    public class ActualizarEspecialidadRequest
    {
        public int nIdEspecialidad { get; set; }
        public string sNombreEspecialidad { get; set; } = default!;
        public int nUsuarioModificacion{ get; set; }
    }
}
