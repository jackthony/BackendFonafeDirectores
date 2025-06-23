using Shared.Kernel.Interfaces;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;

namespace Empresa.Application.Ministerio.Mappers
{
    public class ListarMinisterioPaginadoRequestMapper : IMapper<ListarMinisterioPaginadoRequest, ListarMinisterioPaginadoParameters>
    {
        public ListarMinisterioPaginadoParameters Map(ListarMinisterioPaginadoRequest source)
        {
            return new ListarMinisterioPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                Estado = source.Estado,
                Nombre = source.Nombre,
            };
        }
    }
}
