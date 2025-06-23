namespace Empresa.Presentation.TipoDirector.Responses
{
    public class TipoDirectorResponse
    {
        public int nIdTipoDirector { get; set; }
        public string sNombreTipoDirector { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
    }
}
