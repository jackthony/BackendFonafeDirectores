using Empresa.Domain.Rubro.Results;
using Empresa.Presentation.Rubro.Responses;

namespace Empresa.Presentation.Rubro.Mappers
{
    public static class RubroResponseMapper
    {
        public static RubroResponse ToResponse(RubroResult dto) => new()
        {
        };

        public static IEnumerable<RubroResponse> ToListResponse(IEnumerable<RubroResult> items)
            => items.Select(ToResponse);
    }
}
