/***********
* Nombre del archivo: CrearPermisosRolRequest.cs
* Descripción:        DTO (Data Transfer Object) para la solicitud de creación o actualización
*                     de permisos asociados a un rol. Contiene el identificador del rol, una lista
*                     de módulos con sus respectivas acciones y el estado de sus permisos,
*                     y el ID del usuario que realiza la modificación para fines de auditoría.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para solicitudes de creación/actualización de permisos de rol.
***********/

namespace Usuario.Application.SEG_Rol.Dtos
{
    public class CrearPermisosRolRequest
    {
        public int nRolId { get; set; }
        public List<PermisoPorModuloRequest> lstModulos { get; set; } = [];
        public int nUsuarioModificacionId { get; set; }
    }
}
