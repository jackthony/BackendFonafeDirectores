using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;

namespace Empresa.Application.TipoDirector.Mappers
{
    public class CrearTipoDirectorRequestMapper : IMapper<CrearTipoDirectorRequest, CrearTipoDirectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearTipoDirectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearTipoDirectorParameters Map(CrearTipoDirectorRequest source)
        {
            return new CrearTipoDirectorParameters
            {

            };
        }
    }
}
