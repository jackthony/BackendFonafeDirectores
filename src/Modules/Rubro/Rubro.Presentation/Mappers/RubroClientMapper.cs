using Rubro.Application.Dtos;
using Rubro.Presentation.Dtos.Responses;

namespace Rubro.Presentation.Mappers
{
    public static class RubroClientMapper
    {
        public static RubroClientDto ToClientDto(RubroDto dto) => new()
        {
        };

        public static IEnumerable<RubroClientDto> ToClientDtos(IEnumerable<RubroDto> items)
            => items.Select(ToClientDto);
    }
}
