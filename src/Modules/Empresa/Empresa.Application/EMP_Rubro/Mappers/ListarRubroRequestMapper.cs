using Shared.Kernel.Interfaces;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;

namespace Empresa.Application.Rubro.Mappers
{
    public class ListarRubroRequestMapper : IMapper<ListarRubroRequest, ListarRubroParameters>
    {
        public ListarRubroParameters Map(ListarRubroRequest source)
        {
            return new ListarRubroParameters
            {
            };
        }
    }
}
