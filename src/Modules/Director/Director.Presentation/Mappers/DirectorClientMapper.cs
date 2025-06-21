using Director.Application.Dtos;
using Director.Presentation.Dtos.Responses;

namespace Director.Presentation.Mappers
{
    public static class DirectorClientMapper
    {
        public static DirectorClientDto ToClientDto(DirectorDto dto) => new()
        {
        };

        public static IEnumerable<DirectorClientDto> ToClientDtos(IEnumerable<DirectorDto> items)
            => items.Select(ToClientDto);
    }
}
