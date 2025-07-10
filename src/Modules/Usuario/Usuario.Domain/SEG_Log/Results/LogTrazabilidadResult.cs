/***********
 * Nombre del archivo:  LogTrazabilidadResult.cs
 * Descripción:         Clase que representa el resultado de una consulta de log de trazabilidad.
 *                      Contiene información sobre la acción realizada por un usuario en el sistema,
 *                      incluyendo detalles antes y después del cambio, módulo afectado, y metadatos asociados.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial para manejar resultados de logs de trazabilidad.
 ***********/

namespace Usuario.Domain.SEG_Log.Results
{
    public class LogTrazabilidadResult
    {
        public int Id { get; set; }
        public int? UsuarioId { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? Modulo { get; set; }
        public string? Entidad { get; set; }
        public string? Movimiento { get; set; }
        public DateTime Fecha { get; set; }
        public string? IdSession { get; set; }
        public string? DatosAntes { get; set; }
        public string? DatosDespues { get; set; }
        public string? Detalles { get; set; }
    }
}
