using Shared.Kernel.Interfaces;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;

namespace Empresa.Application.Ubigeo.Mappers
{
    public class ListarUbigeoRequestMapper : IMapper<ListarUbigeoRequest, ListarUbigeoParameters>
    {
        public ListarUbigeoParameters Map(ListarUbigeoRequest source)
        {
            return new ListarUbigeoParameters
            {
            };
        }
    }
}
