/***********
* Nombre del archivo: ActualizarPermisoRolRequest.cs
* Descripción:        **DTO** (Data Transfer Object) para la solicitud de **actualización de un permiso de rol existente**.
*                     Esta clase encapsula los datos necesarios para modificar un permiso específico
*                     asociado a un **rol**, **módulo** y **acción** determinados. Incluye el identificador del
*                     **usuario que realiza la modificación** y la **fecha de la misma** para propósitos de auditoría.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para la actualización de permisos de rol.
***********/

namespace Usuario.Application.PermisoRol.Dtos
{
    public class ActualizarPermisoRolRequest
    {
        public int nRolId { get; set; }
        public int nModuloId { get; set; }
        public int nAccionId { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
