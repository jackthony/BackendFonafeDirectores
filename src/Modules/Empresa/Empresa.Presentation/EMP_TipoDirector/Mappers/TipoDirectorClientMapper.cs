using Empresa.Application.EMP_TipoDirector.Dtos;
using Empresa.Presentation.EMP_TipoDirector.Dtos.Responses;

namespace Empresa.Presentation.EMP_TipoDirector.Mappers
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
