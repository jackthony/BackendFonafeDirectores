namespace Usuario.Domain.SEG_Log.Parameters
{
    public class ObtenerLogSistemaPorFechasRequest
    {
        public required DateTime FechaInicio { get; set; }
        public required DateTime FechaFin { get; set; }
    }
}
