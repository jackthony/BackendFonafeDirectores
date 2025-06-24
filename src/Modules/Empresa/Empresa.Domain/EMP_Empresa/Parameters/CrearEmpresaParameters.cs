namespace Empresa.Domain.Empresa.Parameters
{
    public class CrearEmpresaParameters
    {
        public string Ruc { get; set; } = string.Empty;
        public string RazonSocial { get; set; } = string.Empty;
        public int IdSector { get; set; }
        public int IdRubroNegocio { get; set; }
        public int IdDepartamento { get; set; }
        public int IdProvincia { get; set; }
        public int IdDistrito { get; set; }
        public string Direccion { get; set; } = string.Empty;
        public string Comentario { get; set; } = string.Empty;
        public int NumeroMiembros { get; set; }
        public decimal IngresosUltimoAnio { get; set; }
        public decimal UtilidadUltimoAnio { get; set; }
        public decimal ConformacionCapitalSocial { get; set; }
        public bool RegistradoMercadoValores { get; set; }
        public bool Activo { get; set; }
        public int UsuarioRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
