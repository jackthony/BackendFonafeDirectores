using Empresa.Application.EMP_Sector.Dtos;
using Empresa.Presentation.EMP_Sector.Dtos.Responses;

namespace Empresa.Presentation.EMP_Sector.Mappers
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
