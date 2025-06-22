using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;

namespace Empresa.Application.Director.Mappers
{
    public class CrearDirectorRequestMapper : IMapper<CrearDirectorRequest, CrearDirectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearDirectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearDirectorParameters Map(CrearDirectorRequest source)
        {
            return new CrearDirectorParameters
            {

            };
        }
    }
}
