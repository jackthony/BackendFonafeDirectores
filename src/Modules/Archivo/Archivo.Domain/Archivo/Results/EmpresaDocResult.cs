namespace Archivo.Domain.Archivo.Results
{
    public class EmpresaDocResult
    {
        public string Ruc { get; set; } = string.Empty;
        public string RazonSocial { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;
        public string Provincia { get; set; } = string.Empty;
        public string Distrito { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Rubro { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
        public decimal Ingresos { get; set; }
        public decimal Utilidades { get; set; }
        public decimal CapitalSocial { get; set; }
        public int CantidadMiembros { get; set; }
        public string RegistroEnMercado { get; set; } = string.Empty;
        public string Activo { get; set; } = string.Empty;
        public string Comentario { get; set; } = string.Empty;

        // Campos adicionales no mencionados en la lista
        public int Id { get; set; }
    }
}
