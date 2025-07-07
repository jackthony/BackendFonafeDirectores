namespace Usuario.Domain.SEG_Log.Parameters
{
    public class ObtenerAuditoriaUsuariosRequest
    {
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? Estado { get; set; }
    }
}
