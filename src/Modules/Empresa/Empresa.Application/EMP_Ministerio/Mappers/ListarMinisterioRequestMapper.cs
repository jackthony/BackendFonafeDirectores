using Shared.Kernel.Interfaces;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;

namespace Empresa.Application.Ministerio.Mappers
{
    public class ListarMinisterioRequestMapper : IMapper<ListarMinisterioRequest, ListarMinisterioParameters>
    {
        public ListarMinisterioParameters Map(ListarMinisterioRequest source)
        {
            return new ListarMinisterioParameters
            {
            };
        }
    }
}
