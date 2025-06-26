using Shared.Kernel.Interfaces;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;

namespace Empresa.Application.Sector.Mappers
{
    public class EliminarSectorRequestMapper : IMapper<EliminarSectorRequest, EliminarSectorParameters>
    {
        public EliminarSectorParameters Map(EliminarSectorRequest source)
        {
            return new EliminarSectorParameters
            {
                SectorId = source.nIdSector,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = DateTime.UtcNow
            };
        }
    }
}
