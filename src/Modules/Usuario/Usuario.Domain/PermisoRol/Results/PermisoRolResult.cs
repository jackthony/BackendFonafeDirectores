/***********
 * Nombre del archivo:  PermisoRolResult.cs
 * Descripción:         Clase que representa el resultado de la consulta
 *                      de permisos asociados a roles, con detalles como
 *                      IDs de rol, módulo, acción, usuario que registró,
 *                      fechas de registro y modificación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial de la clase de resultado.
 ***********/

namespace Usuario.Domain.PermisoRol.Results
{
    public class PermisoRolResult
    {
        public int nRolId { get; set; }
        public int nModuloId { get; set; }
        public int nAccionId { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
