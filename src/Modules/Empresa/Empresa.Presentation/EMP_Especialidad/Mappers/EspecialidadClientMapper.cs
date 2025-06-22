using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Presentation.EMP_Especialidad.Dtos.Responses;

namespace Empresa.Presentation.EMP_Especialidad.Mappers
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
