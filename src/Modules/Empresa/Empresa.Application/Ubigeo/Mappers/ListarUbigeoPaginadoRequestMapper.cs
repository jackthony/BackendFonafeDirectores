using Shared.Kernel.Interfaces;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;

namespace Empresa.Application.Ubigeo.Mappers
{
    public class ListarUbigeoPaginadoRequestMapper : IMapper<ListarUbigeoPaginadoRequest, ListarUbigeoPaginadoParameters>
    {
        public ListarUbigeoPaginadoParameters Map(ListarUbigeoPaginadoRequest source)
        {
            return new ListarUbigeoPaginadoParameters
            {
            };
        }
    }
}
