using Ministerio.Application.Dtos;
using Ministerio.Presentation.Dtos.Responses;

namespace Ministerio.Presentation.Mappers
{
    public static class MinisterioClientMapper
    {
        public static MinisterioClientDto ToClientDto(MinisterioDto dto) => new()
        {
        };

        public static IEnumerable<MinisterioClientDto> ToClientDtos(IEnumerable<MinisterioDto> items)
            => items.Select(ToClientDto);
    }
}
