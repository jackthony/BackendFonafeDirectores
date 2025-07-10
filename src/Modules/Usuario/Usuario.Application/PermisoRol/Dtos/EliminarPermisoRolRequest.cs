/***********
* Nombre del archivo: EliminarPermisoRolRequest.cs
* Descripción:        **DTO** (Data Transfer Object) para la solicitud de eliminación de un permiso de rol.
*                     Esta clase encapsula los datos necesarios para identificar y eliminar un permiso
*                     específico asociado a un rol, módulo y acción determinados. Incluye el ID del usuario
*                     que realiza la modificación y la fecha de la misma para propósitos de auditoría.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para la eliminación de permisos de rol.
***********/

namespace Usuario.Application.PermisoRol.Dtos
{
    public class EliminarPermisoRolRequest
    {
        public int nRolId { get; set; }
        public int nModuloId { get; set; }
        public int nAccionId { get; set; }
        public int nUsuarioModificacionId { get; set; }
        public DateTime dtFechaModificacion { get; set; }
    }
}
