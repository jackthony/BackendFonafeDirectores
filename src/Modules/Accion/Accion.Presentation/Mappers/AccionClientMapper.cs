using Accion.Application.Dtos;
using Accion.Presentation.Dtos.Responses;

namespace Accion.Presentation.Mappers
{
    public static class AccionClientMapper
    {
        public static AccionClientDto ToClientDto(AccionDto dto) => new()
        {
        };

        public static IEnumerable<AccionClientDto> ToClientDtos(IEnumerable<AccionDto> items)
            => items.Select(ToClientDto);
    }
}
