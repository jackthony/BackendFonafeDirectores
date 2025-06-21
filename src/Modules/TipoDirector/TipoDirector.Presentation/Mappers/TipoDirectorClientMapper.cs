using TipoDirector.Application.Dtos;
using TipoDirector.Presentation.Dtos.Responses;

namespace TipoDirector.Presentation.Mappers
{
    public static class TipoDirectorClientMapper
    {
        public static TipoDirectorClientDto ToClientDto(TipoDirectorDto dto) => new()
        {
        };

        public static IEnumerable<TipoDirectorClientDto> ToClientDtos(IEnumerable<TipoDirectorDto> items)
            => items.Select(ToClientDto);
    }
}
