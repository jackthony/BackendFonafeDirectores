using Shared.Kernel.Interfaces;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;

namespace Empresa.Application.Ubigeo.Mappers
{
    public class EliminarUbigeoRequestMapper : IMapper<EliminarUbigeoRequest, EliminarUbigeoParameters>
    {
        public EliminarUbigeoParameters Map(EliminarUbigeoRequest source)
        {
            return new EliminarUbigeoParameters
            {
            };
        }
    }
}
