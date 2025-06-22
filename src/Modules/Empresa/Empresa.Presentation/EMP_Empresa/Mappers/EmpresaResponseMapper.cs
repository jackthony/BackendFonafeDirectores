using Empresa.Domain.Empresa.Results;
using Empresa.Presentation.Empresa.Responses;

namespace Empresa.Presentation.Empresa.Mappers
{
    public static class EmpresaResponseMapper
    {
        public static EmpresaResponse ToResponse(EmpresaResult dto) => new()
        {
        };

        public static IEnumerable<EmpresaResponse> ToListResponse(IEnumerable<EmpresaResult> items)
            => items.Select(ToResponse);
    }
}
