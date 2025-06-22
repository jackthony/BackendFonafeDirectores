using Shared.Kernel.Interfaces;
using Shared.Time;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;

namespace Usuario.Application.Modulo.Mappers
{
    public class CrearModuloRequestMapper : IMapper<CrearModuloRequest, CrearModuloParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearModuloRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearModuloParameters Map(CrearModuloRequest source)
        {
            return new CrearModuloParameters
            {
            };
        }
    }
}
