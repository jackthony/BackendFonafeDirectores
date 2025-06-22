using Shared.Kernel.Interfaces;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;

namespace Empresa.Application.Sector.Mappers
{
    public class ListarSectorPaginadoRequestMapper : IMapper<ListarSectorPaginadoRequest, ListarSectorPaginadoParameters>
    {
        public ListarSectorPaginadoParameters Map(ListarSectorPaginadoRequest source)
        {
            return new ListarSectorPaginadoParameters
            {
            };
        }
    }
}
