using Empresa.Domain.Sector.Results;
using Empresa.Presentation.Sector.Responses;

namespace Empresa.Presentation.Sector.Mappers
{
    public static class SectorResponseMapper
    {
        public static SectorResponse ToResponse(SectorResult dto) => new()
        {
        };

        public static IEnumerable<SectorResponse> ToListResponse(IEnumerable<SectorResult> items)
            => items.Select(ToResponse);
    }
}
