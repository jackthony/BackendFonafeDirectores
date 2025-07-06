namespace Usuario.Application.SEG_Log.Dtos
{
    public class LogTrazabilidadRequest
    {
        public required int UsuarioId { get; set; }
        public required string Modulo { get; set; }
        public required string Entidad { get; set; }
        public required string Movimiento { get; set; }
        public string? DatosAntes { get; set; }
        public string? DatosDespues { get; set; }
        public string? Detalles { get; set; }
    }
}
