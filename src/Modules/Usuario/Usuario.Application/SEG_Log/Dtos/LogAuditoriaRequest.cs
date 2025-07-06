namespace Usuario.Application.SEG_Log.Dtos
{
    public class LogAuditoriaRequest
    {
        public int? UsuarioId { get; set; }
        public string Accion { get; set; } = default!;
        public string? Detalles { get; set; }
    }
}
