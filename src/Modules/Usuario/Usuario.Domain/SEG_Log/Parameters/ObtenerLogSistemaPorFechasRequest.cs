/***********
 * Nombre del archivo:  ObtenerLogSistemaPorFechasRequest.cs
 * Descripción:         DTO para solicitar logs de sistema en un rango
 *                      de fechas específico.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación del request para consulta de logs de sistema.
 ***********/

namespace Usuario.Domain.SEG_Log.Parameters
{
    public class ObtenerLogSistemaPorFechasRequest
    {
        public required DateTime FechaInicio { get; set; }
        public required DateTime FechaFin { get; set; }
    }
}
