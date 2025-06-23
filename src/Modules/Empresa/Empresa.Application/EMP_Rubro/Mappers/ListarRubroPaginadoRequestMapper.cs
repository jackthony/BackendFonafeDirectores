using Shared.Kernel.Interfaces;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;

namespace Empresa.Application.Rubro.Mappers
{
    public class ListarRubroPaginadoRequestMapper : IMapper<ListarRubroPaginadoRequest, ListarRubroPaginadoParameters>
    {
        public ListarRubroPaginadoParameters Map(ListarRubroPaginadoRequest source)
        {
            return new ListarRubroPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
            };
        }
    }
}
