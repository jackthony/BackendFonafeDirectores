/***********
 * Nombre del archivo:  LogSistemaResult.cs
 * Descripción:         Clase que representa el resultado de una consulta del log del sistema.
 *                      Contiene información detallada sobre eventos registrados en el sistema,
 *                      como el usuario asociado, tipo de evento, mensaje, traza de pila, fecha,
 *                      estado, origen y datos de sesión e IP.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial para manejo de resultados de logs del sistema.
 ***********/

namespace Usuario.Domain.SEG_Log.Results
{
    public class LogSistemaResult
    {
        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? TipoEvento { get; set; }
        public string? Mensaje { get; set; }
        public string? StackTrace { get; set; }
        public DateTime Fecha { get; set; }
        public string? Origen { get; set; }
        public int? Estado { get; set; }
        public string? Ip { get; set; }
        public string? IdSession { get; set; }
    }
}
