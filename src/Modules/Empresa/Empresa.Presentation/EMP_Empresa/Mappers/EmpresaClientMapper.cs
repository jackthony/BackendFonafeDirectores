using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Presentation.EMP_Empresa.Dtos.Responses;

namespace Empresa.Presentation.EMP_Empresa.Mappers
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
