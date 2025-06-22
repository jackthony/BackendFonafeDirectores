using Shared.Kernel.Interfaces;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;
using Shared.Time;

namespace Empresa.Application.Sector.Mappers
{
    public class ActualizarSectorRequestMapper : IMapper<ActualizarSectorRequest, ActualizarSectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarSectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public ActualizarSectorParameters Map(ActualizarSectorRequest source)
        {
            return new ActualizarSectorParameters
            {
                SectorId = source.SectorId,
                NombreSector = source.NombreSector,
                UsuarioModificacionId = source.UsuarioModificacionId,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }

}
