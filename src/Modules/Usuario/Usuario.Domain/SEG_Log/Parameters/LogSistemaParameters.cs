/***********
 * Nombre del archivo:  LogSistemaParameters.cs
 * Descripción:         Parámetros para el registro y consulta de logs
 *                      del sistema, incluyendo información del usuario,
 *                      tipo de evento, mensaje, rastreo de pila,
 *                      fecha, origen, estado, IP y sesión.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial para manejo de logs de sistema.
 ***********/

namespace Usuario.Domain.SEG_Log.Parameters
{
    public class LogSistemaParameters
    {
        public int? UsuarioId { get; set; }
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
