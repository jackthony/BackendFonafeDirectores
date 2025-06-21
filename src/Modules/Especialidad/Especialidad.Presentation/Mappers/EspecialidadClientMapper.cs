using Especialidad.Application.Dtos;
using Especialidad.Presentation.Dtos.Responses;

namespace Especialidad.Presentation.Mappers
{
    public static class EspecialidadClientMapper
    {
        public static EspecialidadClientDto ToClientDto(EspecialidadDto dto) => new()
        {
        };

        public static IEnumerable<EspecialidadClientDto> ToClientDtos(IEnumerable<EspecialidadDto> items)
            => items.Select(ToClientDto);
    }
}
