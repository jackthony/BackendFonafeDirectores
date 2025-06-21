using Modulo.Application.Dtos;
using Modulo.Presentation.Dtos.Responses;

namespace Modulo.Presentation.Mappers
{
    public static class ModuloClientMapper
    {
        public static ModuloClientDto ToClientDto(ModuloDto dto) => new()
        {
        };

        public static IEnumerable<ModuloClientDto> ToClientDtos(IEnumerable<ModuloDto> items)
            => items.Select(ToClientDto);
    }
}
