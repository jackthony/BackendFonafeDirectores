namespace Empresa.Presentation.Empresa.Responses
{
    public class EmpresaResponse
    {
        public int nIdEmpresa { get; set; }
        public string sRuc { get; set; } = string.Empty;
        public string sRazonSocial { get; set; } = string.Empty;
        public int nIdSector { get; set; }
        public int nIdRubroNegocio { get; set; }
        public string sIdDepartamento { get; set; } = string.Empty;
        public string sIdProvincia { get; set; } = string.Empty;
        public string sIdDistrito { get; set; } = string.Empty;
        public string sDireccion { get; set; } = string.Empty;
        public string sComentario { get; set; } = string.Empty;
        public decimal mIngresosUltimoAnio { get; set; }
        public decimal mUtilidadUltimoAnio { get; set; }
        public decimal mConformacionCapitalSocial { get; set; }
        public int nNumeroMiembros { get; set; }
        public bool bRegistradoMercadoValores { get; set; }
        public bool bActivo { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioRegistro { get; set; }
        public DateTime? dtFechaModificacion { get; set; }
        public int? nUsuarioModificacion { get; set; }
        public string? sDescripcionRubro { get; set; }
        public string? sNombreMinisterio { get; set; }
        public string? sProvinciaDescripcion { get; set; }
        public int indice { get; set; }
    }
}
