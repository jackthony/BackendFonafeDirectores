/***********
 * Nombre del archivo:  EliminarPermisoRolParameters.cs
 * Descripción:         Clase que encapsula los parámetros necesarios
 *                      para eliminar un permiso asignado a un rol,
 *                      incluyendo identificadores y datos de modificación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial de la clase de parámetros.
 ***********/

namespace Usuario.Domain.PermisoRol.Parameters
{
    public class EliminarPermisoRolParameters
    {
        public int nRolId { get; set; }
        public int nModuloId { get; set; }
        public int nAccionId { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
