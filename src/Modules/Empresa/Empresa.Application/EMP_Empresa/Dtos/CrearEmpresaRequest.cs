using Shared.Kernel.Interfaces;

namespace Empresa.Application.Empresa.Dtos
{
    public class CrearEmpresaRequest : ITrackableRequest
    {
        public string sRuc { get; set; } = string.Empty;
        public string sRazonSocial { get; set; } = string.Empty;
        public int nIdSector { get; set; }
        public int nIdRubroNegocio { get; set; }
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
        public int nUsuarioRegistro { get; set; }

        public int UsuarioId => nUsuarioRegistro;
        public string Modulo => "EMPRESA";
        public string Tabla => "EMP_Empresa";
        public string CampoId => "nEmpresaId";
        public int? ValorId => null;
        public string Movimiento => "Create";
    }
}
