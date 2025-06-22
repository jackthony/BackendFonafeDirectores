using Shared.Kernel.Interfaces;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;

namespace Empresa.Application.TipoDirector.Mappers
{
    public class ListarTipoDirectorPaginadoRequestMapper : IMapper<ListarTipoDirectorPaginadoRequest, ListarTipoDirectorPaginadoParameters>
    {
        public ListarTipoDirectorPaginadoParameters Map(ListarTipoDirectorPaginadoRequest source)
        {
            return new ListarTipoDirectorPaginadoParameters
            {
            };
        }
    }
}
