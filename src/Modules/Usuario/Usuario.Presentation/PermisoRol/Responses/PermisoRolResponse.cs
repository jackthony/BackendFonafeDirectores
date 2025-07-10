/***********
 * Nombre del archivo:  PermisoRolResponse.cs
 * Descripción:         Clase de respuesta que representa los permisos asignados a un rol,
 *                      incluyendo información sobre el módulo, acción y trazabilidad.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Definición inicial de la estructura de respuesta para los permisos por rol.
 ***********/

namespace Usuario.Presentation.PermisoRol.Responses
{
    public class PermisoRolResponse
    {
        public int nRolId { get; set; }
        public int nModuloId { get; set; }
        public int nAccionId { get; set; }
        public int nUsuarioRegistroId { get; set; }
        public DateTime dtFechaRegistro { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
        public int indice { get; set; }
    }
}
