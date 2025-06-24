namespace Empresa.Application.Empresa.Dtos
{
    public class ActualizarEmpresaRequest
    {
        public int nIdEmpresa { get; set; }
        public int nIdRubroNegocio { get; set; }
        public int nIdSector { get; set; }
        public string sIdDepartamento { get; set; } = string.Empty;
        public string sIdProvincia { get; set; } = string.Empty;
        public string sIdDistrito { get; set; } = string.Empty;
        public string sDireccion { get; set; } = string.Empty;
        public string sComentario { get; set; } = string.Empty;
        public int nNumeroMiembros { get; set; }
        public decimal mIngresosUltimoAnio { get; set; }
        public decimal mUtilidadUltimoAnio { get; set; }
        public decimal mConformacionCapitalSocial { get; set; }
        public bool bRegistradoMercadoValores { get; set; }
        public bool bActivo { get; set; }
        public int nUsuarioModificacion { get; set; }
    }
}
