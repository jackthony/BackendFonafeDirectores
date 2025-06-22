using Shared.Kernel.Interfaces;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;

namespace Empresa.Application.Cargo.Mappers
{
    public class ListarCargoRequestMapper : IMapper<ListarCargoRequest, ListarCargoParameters>
    {
        public ListarCargoParameters Map(ListarCargoRequest source)
        {
            throw new NotImplementedException();
        }
    }
}
