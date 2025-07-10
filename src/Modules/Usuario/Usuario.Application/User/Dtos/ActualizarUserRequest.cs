/***********
* Nombre del archivo: ActualizarUserRequest.cs
* Descripción:        DTO (Data Transfer Object) para la solicitud de actualización de un usuario existente.
*                     Implementa 'ITrackableRequest' para fines de auditoría y contiene los
*                     campos necesarios para modificar la información de un usuario, incluyendo
*                     el identificador del usuario a modificar, el de quien realiza la modificación,
*                     y los metadatos para el seguimiento de la operación.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para solicitudes de actualización de usuario.
***********/

using Shared.Kernel.Interfaces;

namespace Usuario.Application.User.Dtos
{
    public class ActualizarUserRequest : ITrackableRequest
    {
        public required int nIdUsuario { get; set; }
        public required int nUsuarioModificacion { get; set; }
        public int nIdRol { get; set; }
        public int nEstado { get; set; }
        public int nIdCargo { get; set; }
        public int nTipoPersonal { get; set; }

        public int UsuarioId => nUsuarioModificacion;
        public string Modulo => "USUARIO";
        public string Tabla => "SEG_Usuario";
        public string CampoId => "nUsuarioId";
        public int? ValorId => nIdUsuario;
        public string Movimiento => "Update";
    }
}
