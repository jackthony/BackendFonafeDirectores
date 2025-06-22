namespace Empresa.Application.Especialidad.Dtos
{
    public class CrearEspecialidadRequest
    {
        public string NombreEspecialidad { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
    }
}
