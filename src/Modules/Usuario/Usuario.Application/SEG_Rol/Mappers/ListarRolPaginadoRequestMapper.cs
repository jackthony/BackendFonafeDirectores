using Shared.Kernel.Interfaces;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Parameters;

namespace Usuario.Application.Rol.Mappers
{
    public class ListarRolPaginadoRequestMapper : IMapper<ListarRolPaginadoRequest, ListarRolPaginadoParameters>
    {
        public ListarRolPaginadoParameters Map(ListarRolPaginadoRequest source)
        {
            return new ListarRolPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
            };
        }
    }
}
