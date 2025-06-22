using Empresa.Application.EMP_Director.Dtos;
using Empresa.Presentation.EMP_Director.Dtos.Responses;

namespace Empresa.Presentation.EMP_Director.Mappers
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
