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
