namespace Empresa.Domain.Especialidad.Parameters
{
    public class CrearEspecialidadParameters
    {
        public string NombreEspecialidad { get; set; } = default!;
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
