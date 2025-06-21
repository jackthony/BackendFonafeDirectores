using Usuario.Application.Dtos;
using Usuario.Presentation.Dtos.Responses;

namespace Usuario.Presentation.Mappers
{
    public static class UsuarioClientMapper
    {
        public static UsuarioClientDto ToClientDto(UsuarioDto dto) => new()
        {
        };

        public static IEnumerable<UsuarioClientDto> ToClientDtos(IEnumerable<UsuarioDto> items)
            => items.Select(ToClientDto);
    }
}
