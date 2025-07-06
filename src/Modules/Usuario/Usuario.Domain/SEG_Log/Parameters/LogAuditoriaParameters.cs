namespace Usuario.Domain.SEG_Log.Parameters
{
    public class LogAuditoriaParameters
    {
        public int UsuarioId { get; set; }
        public string Accion { get; set; } = default!;
        public DateTime Fecha { get; set; }
        public string? Ip { get; set; }
        public string? Detalles { get; set; }
    }
}
