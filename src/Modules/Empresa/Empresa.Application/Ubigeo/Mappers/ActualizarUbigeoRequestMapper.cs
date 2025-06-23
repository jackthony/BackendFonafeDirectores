using Shared.Kernel.Interfaces;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;

namespace Empresa.Application.Ubigeo.Mappers
{
    public class ActualizarUbigeoRequestMapper : IMapper<ActualizarUbigeoRequest, ActualizarUbigeoParameters>
    {
        public ActualizarUbigeoParameters Map(ActualizarUbigeoRequest source)
        {
            return new ActualizarUbigeoParameters
            {
            };
        }
    }
}
