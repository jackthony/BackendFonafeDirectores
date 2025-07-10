/***********
* Nombre del archivo: EliminarRolRequest.cs
* Descripción:        DTO (Data Transfer Object) para la solicitud de eliminación de un rol.
*                     Contiene el identificador del rol a eliminar y el ID del usuario que
*                     realiza la modificación, para propósitos de auditoría y trazabilidad.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para la solicitud de eliminación de rol.
***********/

namespace Usuario.Application.Rol.Dtos
{
    public class EliminarRolRequest
    {
        public int nRolId { get; set; }
        public int nUsuarioModificacionId { get; set; }
    }
}
