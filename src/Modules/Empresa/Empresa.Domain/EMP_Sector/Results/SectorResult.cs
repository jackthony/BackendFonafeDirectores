namespace Empresa.Domain.Sector.Results
{
    public class SectorResult
    {
        public int SectorId { get; set; }
        public string NombreSector { get; set; } = default!;
        public bool IsActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacionId { get; set; }
    }
}
