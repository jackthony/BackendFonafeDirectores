namespace Archivo.Presentation.Archivo.Responses
{
    public class ElementoDetalleResponse
    {
        public int tipo { get; set; }
        public long nPeso { get; set; }
        public string sTipoMime { get; set; } = string.Empty;
        public string sUrlStorage { get; set; } = string.Empty;
        public bool bEsDocumento { get; set; }
        public int nElementoId { get; set; }
        public string sNombre { get; set; } = string.Empty;
        public int? nCarpetaPadreId { get; set; }
        public int nEmpresaId { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime stFechaRegistro { get; set; }
    }
}
