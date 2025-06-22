using Shared.Kernel.Interfaces;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;

namespace Empresa.Application.Cargo.Mappers
{
    public class ListarCargoPaginadoRequestMapper : IMapper<ListarCargoPaginadoRequest, ListarCargoPaginadoParameters>
    {
        public ListarCargoPaginadoParameters Map(ListarCargoPaginadoRequest source)
        {
            return new ListarCargoPaginadoParameters
            {
            };
        }
    }
}
