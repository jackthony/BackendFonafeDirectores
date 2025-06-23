namespace Empresa.Application.Especialidad.Dtos
{
    public class CrearEspecialidadRequest
    {
        public string sNombreEspecialidad { get; set; } = default!;
        public int nUsuarioRegistro{ get; set; }
    }
}
