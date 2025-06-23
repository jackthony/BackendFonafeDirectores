namespace Empresa.Presentation.Sector.Responses
{
    public class SectorResponse
    {
        public int nIdSector { get; set; }
        public string sNombreSector { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
    }
}
