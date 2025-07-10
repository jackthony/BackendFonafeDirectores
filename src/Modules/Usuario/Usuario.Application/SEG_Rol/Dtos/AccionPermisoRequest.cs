/***********
* Nombre del archivo: AccionPermisoRequest.cs
* Descripción:        DTO (Data Transfer Object) que representa el estado de un permiso para una acción específica.
*                     Contiene el identificador de la acción y un booleano que indica
*                     si el permiso para dicha acción está concedido (`true`) o denegado (`false`).
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para el estado de una acción de permiso.
***********/

namespace Usuario.Application.SEG_Rol.Dtos
{
    public class AccionPermisoRequest
    {
        public int nAccionId { get; set; }
        public bool bPermitir { get; set; }
    }
}
