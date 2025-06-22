namespace Empresa.Domain.TipoDirector.Results
{
    public class TipoDirectorResult
    {
        public int TipoDirectorId { get; set; }
        public string NombreTipoDirector { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
