using Shared.Kernel.Interfaces;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;

namespace Usuario.Application.Rol.Mappers
{
    public class ListarRolRequestMapper : IMapper<ListarRolRequest, ListarRolParameters>
    {
        public ListarRolParameters Map(ListarRolRequest source)
        {
            return new ListarRolParameters
            {
            };
        }
    }
}
