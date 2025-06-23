using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;

namespace Empresa.Application.Ubigeo.Mappers
{
    public class CrearUbigeoRequestMapper : IMapper<CrearUbigeoRequest, CrearUbigeoParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearUbigeoRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearUbigeoParameters Map(CrearUbigeoRequest source)
        {
            return new CrearUbigeoParameters
            {
            };
        }
    }
}
