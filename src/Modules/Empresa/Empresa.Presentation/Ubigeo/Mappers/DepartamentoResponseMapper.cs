using Empresa.Domain.Departamento.Results;
using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Departamento.Responses;

namespace Empresa.Presentation.Departamento.Mappers
{
    public static class DepartamentoResponseMapper
    {
        public static DepartamentoResponse ToResponse(DepartamentoResult dto) => new()
        {
        };

        public static IEnumerable<DepartamentoResponse> ToListResponse(IEnumerable<DepartamentoResult> items)
            => items.Select(ToResponse);
    }
}
