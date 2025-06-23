using Empresa.Domain.Sector.Results;
using Empresa.Presentation.Sector.Responses;

namespace Empresa.Presentation.Sector.Mappers
{
    public static class SectorResponseMapper
    {
        public static SectorResponse ToResponse(SectorResult dto) => new()
        {
            nIdSector = dto.SectorId,
            sNombreSector = dto.NombreSector,
            bActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacionId
        };

        public static IEnumerable<SectorResponse> ToListResponse(IEnumerable<SectorResult> items)
            => items.Select(ToResponse);
    }
}
