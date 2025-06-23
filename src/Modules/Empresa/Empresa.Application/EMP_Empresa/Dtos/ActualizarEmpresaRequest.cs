namespace Empresa.Application.Empresa.Dtos
{
    public class ActualizarEmpresaRequest
    {
        public string sRuc { get; set; } = string.Empty;
        public string sRazonSocial { get; set; } = string.Empty;
        public int nSectorId { get; set; }
        public int nRubroId { get; set; }
        public int nDepartamentoId { get; set; }
        public int nProvinciaId { get; set; }
        public int nDistritoId { get; set; }
        public string? sDireccion { get; set; } = string.Empty;
        public string? sComentario { get; set; } = string.Empty;
        public decimal dIngresosUltimoAnio { get; set; }
        public decimal dUtilidadUltimoAnio { get; set; }
        public decimal dConformacionCapitalSocial { get; set; }
        public int nNumeroMiembros { get; set; }
        public bool bRegistradoMercadoValor { get; set; }
        public DateTime? dtFechaModificacion { get; set; } = null;
        public int? nUsuarioModificacionId { get; set; } = null;
    }
}
