/***********
 * Nombre del archivo:  ObtenerUsuariosPorTipoUsuarioRequest.cs
 * Descripción:         DTO para solicitar listado de usuarios filtrados por tipo de usuario
 *                      y rango de fechas opcional.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del request con filtros de tipo usuario y fechas.
 ***********/

namespace Usuario.Domain.SEG_Log.Parameters
{
    public class ObtenerUsuariosPorTipoUsuarioRequest
    {
        public required int TipoUsuario { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
    }
}
