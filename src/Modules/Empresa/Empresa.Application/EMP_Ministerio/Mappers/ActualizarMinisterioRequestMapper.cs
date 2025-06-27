using Shared.Kernel.Interfaces;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;
using Shared.Time;

namespace Empresa.Application.Ministerio.Mappers
{
    public class ActualizarMinisterioRequestMapper : IMapper<ActualizarMinisterioRequest, ActualizarMinisterioParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarMinisterioRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public ActualizarMinisterioParameters Map(ActualizarMinisterioRequest source)
        {
            return new ActualizarMinisterioParameters
            {
                MinisterioId = source.nIdMinisterio,
                NombreMinisterio = source.sNombreMinisterio,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }
}
