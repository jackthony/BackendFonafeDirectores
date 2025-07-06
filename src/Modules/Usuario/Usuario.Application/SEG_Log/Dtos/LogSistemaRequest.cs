namespace Usuario.Application.SEG_Log.Dtos
{
    public class LogSistemaRequest
    {
        public int? UsuarioId { get; set; }
        public string? TipoEvento { get; set; }
        public string? Mensaje { get; set; }
        public string? StackTrace { get; set; }
        public string? Origen { get; set; }
        public int? Estado { get; set; }
        public string? Ip { get; set; }
        public string? IdSession { get; set; }
    }
}
