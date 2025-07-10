/***********
 * Nombre del archivo:  AuditLogEstadoUsuarioResult.cs
 * Descripción:         Clase que representa el resultado del log de auditoría del estado de un usuario.
 *                      Contiene información personal del usuario y detalles sobre el cambio de estado histórico,
 *                      incluyendo la fecha en que se realizó dicho cambio.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial para capturar y mostrar cambios históricos en el estado del usuario.
 ***********/

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
