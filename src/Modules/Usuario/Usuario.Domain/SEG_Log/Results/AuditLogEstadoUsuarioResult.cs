namespace Usuario.Domain.SEG_Log.Results
{
    public class AuditLogEstadoUsuarioResult
    {
        public string Username { get; set; } = null!;
        public string CorreoElectronico { get; set; } = null!;
        public string ApellidoPaterno { get; set; } = null!;
        public string ApellidoMaterno { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public string EstadoHistorico { get; set; } = null!;
        public DateTime FechaCambio { get; set; }
    }
}
