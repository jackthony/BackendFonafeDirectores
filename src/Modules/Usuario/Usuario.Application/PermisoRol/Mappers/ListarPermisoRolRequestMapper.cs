/***********
* Nombre del archivo: ListarPermisoRolRequestMapper.cs
* Descripción:        **Implementación del mapeador** para transformar una **`ListarPermisoRolRequest`** (DTO de aplicación)
*                     a **`ListarPermisoRolParameters`** (parámetros de dominio). Este mapeador es responsable
*                     de convertir los datos de la solicitud de listar permisos de rol para que sean
*                     utilizables por la capa de dominio. Actualmente, se inicializa sin mapeo de propiedades,
*                     indicando que la solicitud podría no contener filtros específicos y simplemente se usa para invocar la lista completa.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;

namespace Usuario.Application.PermisoRol.Mappers
{
    public class ListarPermisoRolRequestMapper : IMapper<ListarPermisoRolRequest, ListarPermisoRolParameters>
    {
        public ListarPermisoRolParameters Map(ListarPermisoRolRequest source)
        {
            return new ListarPermisoRolParameters
            {
            };
        }
    }
}
