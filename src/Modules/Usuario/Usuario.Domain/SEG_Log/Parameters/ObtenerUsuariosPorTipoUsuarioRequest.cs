namespace Usuario.Domain.SEG_Log.Parameters
{
    public class ObtenerUsuariosPorTipoUsuarioRequest
    {
        public required int TipoUsuario { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
