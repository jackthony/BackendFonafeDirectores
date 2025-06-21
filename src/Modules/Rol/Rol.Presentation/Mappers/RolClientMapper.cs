using Rol.Application.Dtos;
using Rol.Presentation.Dtos.Responses;

namespace Rol.Presentation.Mappers
{
    public static class RolClientMapper
    {
        public static RolClientDto ToClientDto(RolDto dto) => new()
        {
        };

        public static IEnumerable<RolClientDto> ToClientDtos(IEnumerable<RolDto> items)
            => items.Select(ToClientDto);
    }
}
