using Shared.Kernel.Interfaces;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;

namespace Usuario.Application.PermisoRol.Mappers
{
    public class ListarPermisoRolPaginadoRequestMapper : IMapper<ListarPermisoRolPaginadoRequest, ListarPermisoRolPaginadoParameters>
    {
        public ListarPermisoRolPaginadoParameters Map(ListarPermisoRolPaginadoRequest source)
        {
            return new ListarPermisoRolPaginadoParameters
            {
            };
        }
    }
}
