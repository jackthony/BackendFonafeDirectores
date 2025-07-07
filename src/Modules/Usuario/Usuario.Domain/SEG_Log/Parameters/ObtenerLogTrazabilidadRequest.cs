namespace Usuario.Domain.SEG_Log.Parameters
{
    public class ObtenerLogTrazabilidadRequest
    {
        public required DateTime FechaInicio { get; set; }
        public required DateTime FechaFin { get; set; }
    }
}
