namespace Usuario.Domain.SEG_Log.Results
{
    public class LogTrazabilidadResult
    {
        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? Modulo { get; set; }
        public string? Entidad { get; set; }
        public string? Movimiento { get; set; }
        public DateTime Fecha { get; set; }
        public string? IdSession { get; set; }
        public string? DatosAntes { get; set; }
        public string? DatosDespues { get; set; }
        public string? Detalles { get; set; }
    }
}
