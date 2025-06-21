using Sector.Application.Dtos;
using Sector.Presentation.Dtos.Responses;

namespace Sector.Presentation.Mappers
{
    public static class SectorClientMapper
    {
        public static SectorClientDto ToClientDto(SectorDto dto) => new()
        {
        };

        public static IEnumerable<SectorClientDto> ToClientDtos(IEnumerable<SectorDto> items)
            => items.Select(ToClientDto);
    }
}
