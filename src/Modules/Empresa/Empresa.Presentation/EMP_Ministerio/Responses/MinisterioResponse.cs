namespace Empresa.Presentation.Ministerio.Responses
{
    public class MinisterioResponse
    {
        public int nIdMinisterio { get; set; }
        public string sNombreMinisterio { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public int indice { get; set; }
    }
}
