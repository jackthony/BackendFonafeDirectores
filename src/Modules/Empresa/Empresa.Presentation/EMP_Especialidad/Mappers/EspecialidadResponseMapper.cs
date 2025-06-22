using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Responses;

namespace Empresa.Presentation.Especialidad.Mappers
{
    public static class EspecialidadResponseMapper
    {
        public static EspecialidadResponse ToResponse(EspecialidadResult dto) => new()
        {
        };

        public static IEnumerable<EspecialidadResponse> ToListResponse(IEnumerable<EspecialidadResult> items)
            => items.Select(ToResponse);
    }
}
