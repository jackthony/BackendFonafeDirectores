using Shared.Kernel.Interfaces;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;
using Shared.Time;

namespace Empresa.Application.TipoDirector.Mappers
{
    public class ActualizarTipoDirectorRequestMapper : IMapper<ActualizarTipoDirectorRequest, ActualizarTipoDirectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarTipoDirectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public ActualizarTipoDirectorParameters Map(ActualizarTipoDirectorRequest source)
        {
            return new ActualizarTipoDirectorParameters
            {
                TipoDirectorId = source.TipoDirectorId,
                NombreTipoDirector = source.NombreTipoDirector,
                UsuarioModificacionId = source.UsuarioModificacionId,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }

}
