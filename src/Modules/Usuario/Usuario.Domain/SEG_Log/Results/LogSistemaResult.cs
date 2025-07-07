namespace Usuario.Domain.SEG_Log.Results
{
    public class LogSistemaResult
    {
        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? TipoEvento { get; set; }
        public string? Mensaje { get; set; }
        public string? StackTrace { get; set; }
        public DateTime Fecha { get; set; }
        public string? Origen { get; set; }
        public int? Estado { get; set; }
        public string? Ip { get; set; }
        public string? IdSession { get; set; }
    }
}
