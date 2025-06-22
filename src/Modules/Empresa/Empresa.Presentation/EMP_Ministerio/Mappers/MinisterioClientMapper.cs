using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Presentation.EMP_Ministerio.Dtos.Responses;

namespace Empresa.Presentation.EMP_Ministerio.Mappers
{
    public static class MinisterioClientMapper
    {
        public static MinisterioClientDto ToClientDto(MinisterioDto dto) => new()
        {
        };

        public static IEnumerable<MinisterioClientDto> ToClientDtos(IEnumerable<MinisterioDto> items)
            => items.Select(ToClientDto);
    }
}
