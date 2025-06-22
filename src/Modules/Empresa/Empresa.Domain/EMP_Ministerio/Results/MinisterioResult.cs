namespace Empresa.Domain.Ministerio.Results
{
    public class MinisterioResult
    {
        public int MinisterioId { get; set; }
        public string NombreMinisterio { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
