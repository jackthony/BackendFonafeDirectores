/***********
* Nombre del archivo: ActualizarPermisoRolParameters.cs
* Descripción:        Parámetros para la actualización de un permiso asociado a un rol.
*                     Define los datos necesarios para modificar un permiso específico
*                     que tiene un rol sobre un módulo y acción.
* Autor:              Daniel Alva
* Fecha de creación:  09/07/2025
* Última modificación:09/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase para definir los parámetros de actualización de permiso de rol.
***********/

namespace Usuario.Domain.PermisoRol.Parameters
{
    public class ActualizarPermisoRolParameters
    {
        public int nRolId { get; set; }
        public int nModuloId { get; set; }
        public int nAccionId { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
