using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;

namespace Empresa.Application.Especialidad.Mappers
{
    public class CrearEspecialidadRequestMapper : IMapper<CrearEspecialidadRequest, CrearEspecialidadParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearEspecialidadRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearEspecialidadParameters Map(CrearEspecialidadRequest source)
        {
            return new CrearEspecialidadParameters
            {

            };
        }
    }
}
