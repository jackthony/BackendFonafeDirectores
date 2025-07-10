/***********
* Nombre del archivo: PermisoPorModuloRequest.cs
* Descripción:        DTO (Data Transfer Object) que representa los permisos de un rol dentro de un módulo específico.
*                     Contiene el identificador del módulo y una lista de acciones
*                     asociadas a ese módulo, indicando si el permiso para cada acción está concedido o no.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase DTO para agrupar permisos por módulo.
***********/

namespace Usuario.Application.SEG_Rol.Dtos
{
    public class PermisoPorModuloRequest
    {
        public int nModuloId { get; set; }
        public List<AccionPermisoRequest> lstAcciones { get; set; } = [];
    }
}
