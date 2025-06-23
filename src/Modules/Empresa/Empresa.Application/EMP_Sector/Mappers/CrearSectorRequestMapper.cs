using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;

namespace Empresa.Application.Sector.Mappers
{
    public class CrearSectorRequestMapper : IMapper<CrearSectorRequest, CrearSectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearSectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearSectorParameters Map(CrearSectorRequest source)
        {
            return new CrearSectorParameters
            {
                NombreSector = source.sNombreSector,
                UsuarioRegistroId = source.nUsuarioRegistro,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
