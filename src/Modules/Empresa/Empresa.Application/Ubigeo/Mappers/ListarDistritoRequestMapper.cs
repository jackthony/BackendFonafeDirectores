using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Distrito.Mappers
{
    public class ListarDistritoRequestMapper : IMapper<ListarDistritoRequest, ListarDistritoParameters>
    {
        public ListarDistritoParameters Map(ListarDistritoRequest source)
        {
            return new ListarDistritoParameters
            {
                Nombre = source.sNombre,
                ProvinciaId = int.Parse(source.sCode)
            };
        }
    }
}
