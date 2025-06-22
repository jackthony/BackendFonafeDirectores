using Empresa.Application.EMP_Rubro.Dtos;
using Empresa.Presentation.EMP_Rubro.Dtos.Responses;

namespace Empresa.Presentation.EMP_Rubro.Mappers
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
