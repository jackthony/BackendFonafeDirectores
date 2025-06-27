namespace Empresa.Domain.Especialidad.Results
{
    public class EspecialidadResult
    {
        public int EspecialidadId { get; set; }
        public string NombreEspecialidad { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
