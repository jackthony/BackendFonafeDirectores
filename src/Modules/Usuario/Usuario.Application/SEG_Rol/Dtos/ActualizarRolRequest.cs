/***********
* Nombre del archivo: ActualizarRolRequest.cs
* Descripción:        DTO (Data Transfer Object) para la solicitud de actualización de un rol existente.
*                     Contiene el identificador del rol a modificar, el ID del usuario que
*                     realiza la modificación, la fecha de modificación y el nuevo nombre del rol.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para la solicitud de actualización de rol.
***********/

namespace Usuario.Application.Rol.Dtos
{
    public class ActualizarRolRequest
    {
        public int nRolId { get; set; }
        public int nIdUsuarioModificacion { get; set; }
        public DateTime dtFechaModificacion { get; set; } = DateTime.Now;
        public string sNombreRol { get; set; } = string.Empty;
    }
}
