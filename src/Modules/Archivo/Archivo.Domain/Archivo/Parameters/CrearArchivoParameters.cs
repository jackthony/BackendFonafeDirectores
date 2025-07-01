namespace Archivo.Domain.Archivo.Parameters
{
    public class CrearArchivoParameters
    {
        public bool IsDocumento { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public int? CarpetaPadreId { get; set; }
        public int UsuarioRegistroId { get; set; }
        public required string EmpresaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public long? Peso { get; set; }
        public string? TipoMime { get; set; }
        public string? UrlStorage { get; set; }
    }
}
