namespace Empresa.Domain.Empresa.Results
{
    public class EmpresaResult
    {
        public int EmpresaId { get; set; }

        public string Ruc { get; set; } = string.Empty;


        public string RazonSocial { get; set; } = string.Empty;


        public string SectorNombre { get; set; } = string.Empty;

        public string RubroNombre { get; set; } = string.Empty;

        public string Departamento { get; set; } = string.Empty;

        public string Provincia { get; set; } = string.Empty;

        public string Distrito { get; set; } = string.Empty;

        public string? Direccion { get; set; } = string.Empty;


        public string? Comentario { get; set; } = string.Empty;


        public decimal IngresosUltimoAnio { get; set; }

        public decimal UtilidadUltimoAnio { get; set; }

        public decimal ConformacionCapitalSocial { get; set; }

        public int NumeroMiembros { get; set; }

        public bool RegistradoMercadoValor { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaRegistro { get; set; }

        public string UsuarioRegistro { get; set; } = string.Empty;

        public DateTime? FechaModificacion { get; set; }

        public string? UsuarioModificacion { get; set; } = string.Empty;
    }
}
