namespace Usuario.Domain.Modulo.Results
{
    public class ModuloConAccionesResult
    {
        public int ModuloId { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Ruta { get; set; }
        public string? Icono { get; set; }
        public bool ModuloPermitido { get; set; }
        public string AccionesJson { get; set; } = string.Empty;
    }
}
