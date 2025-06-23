using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Responses;

namespace Empresa.Presentation.Ubigeo.Mappers
{
    public static class DistritoResponseMapper
    {
        public static DistritoResponse ToResponse(DistritoResult dto) => new()
        {
            sCode = dto.DistritoId.ToString("D4"),
            sName = dto.NombreDistrito,
            sProvinceCode = dto.ProvinciaId.ToString("D4")
        };

        public static IEnumerable<DistritoResponse> ToListResponse(IEnumerable<DistritoResult> items)
            => items.Select(ToResponse);
    }
}
