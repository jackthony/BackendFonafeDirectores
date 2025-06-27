namespace Empresa.Domain.Empresa.Results
{
    public class EmpresaResult
    {
        public int IdEmpresa { get; set; }
        public string Ruc { get; set; } = string.Empty;
        public string RazonSocial { get; set; } = string.Empty;
        public int IdSector { get; set; }
        public int IdRubroNegocio { get; set; }
        public int IdDepartamento { get; set; }
        public int IdProvincia { get; set; }
        public int IdDistrito { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Comentario { get; set; } = string.Empty;
        public decimal IngresosUltimoAnio { get; set; }
        public decimal UtilidadUltimoAnio { get; set; }
        public decimal ConformacionCapitalSocial { get; set; }
        public int NumeroMiembros { get; set; }
        public bool RegistradoMercadoValores { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistro { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public string DescripcionRubro { get; set; } = string.Empty;
        public string NombreMinisterio { get; set; } = string.Empty;
        public string ProvinciaDescripcion { get; set; } = string.Empty;
    }
}
