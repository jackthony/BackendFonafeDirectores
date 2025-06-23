namespace Empresa.Presentation.Rubro.Responses
{
    public class RubroResponse
    {
        public int nIdRubro { get; set; }
        public string sNombreRubro { get; set; } = string.Empty;
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
    }
}
