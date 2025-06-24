using Shared.Kernel.Interfaces;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;
using Shared.Time;

namespace Empresa.Application.Director.Mappers
{
    public class EliminarDirectorRequestMapper : IMapper<EliminarDirectorRequest, EliminarDirectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public EliminarDirectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }
        public EliminarDirectorParameters Map(EliminarDirectorRequest source)
        {
            return new EliminarDirectorParameters
            {
                nDirectorId = source.nDirectorId,
                dtFechaModificacion = source.dtFechaModificacion,
                nUsuarioModificacionId = _timeProvider.NowPeru
            };
        }
    }
}
