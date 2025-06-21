using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Presentation.Dtos.Responses;

namespace Empresa.Presentation.Mappers
{
    public static class EmpresaClientMapper
    {
        public static EmpresaClientDto ToClientDto(EmpresaDto dto) => new()
        {
        };

        public static IEnumerable<EmpresaClientDto> ToClientDtos(IEnumerable<EmpresaDto> items)
            => items.Select(ToClientDto);
    }
}
