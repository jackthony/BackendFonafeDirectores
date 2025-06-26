using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Responses;

namespace Empresa.Presentation.Ubigeo.Mappers
{
    public static class DepartamentoResponseMapper
    {
        public static DepartamentoResponse ToResponse(DepartamentoResult dto) => new()
        {
            sCode = dto.DepartamentoId.ToString("D4"),
            sName = dto.NombreDepartamento
        };

        public static IEnumerable<DepartamentoResponse> ToListResponse(IEnumerable<DepartamentoResult> items)
            => items.Select(ToResponse);
    }
}
