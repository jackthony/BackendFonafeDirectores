/***********
 * Nombre del archivo:  ObtenerAuditoriaUsuariosRequest.cs
 * Descripción:         DTO para solicitar la auditoría de usuarios,
 *                      filtrando por rango de fechas y estado.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación del request para consulta de auditoría de usuarios.
 ***********/

namespace Usuario.Domain.SEG_Log.Parameters
{
    public class ObtenerAuditoriaUsuariosRequest
    {
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int? Estado { get; set; }
    }
}
