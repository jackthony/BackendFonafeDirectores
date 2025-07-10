/***********
 * Nombre del archivo:  LogTrazabilidadParameters.cs
 * Descripción:         Parámetros para filtrar o registrar logs
 *                      de trazabilidad, incluyendo usuario, módulo,
 *                      entidad, movimiento, sesión y detalles.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Definición inicial de parámetros para trazabilidad.
 ***********/

namespace Usuario.Domain.SEG_Log.Parameters
{
    public class LogTrazabilidadParameters
    {
        public int UsuarioId { get; set; }
        public string? Modulo { get; set; }
        public string? Entidad { get; set; }
        public string? Movimiento { get; set; }
        public string? IdSession { get; set; }
        public DateTime Fecha { get; set; }
        public string? DatosAntes { get; set; }
        public string? DatosDespues { get; set; }
        public string? Detalles { get; set; }
    }
}
