using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Responses;

namespace Empresa.Presentation.TipoDirector.Mappers
{
    public static class TipoDirectorResponseMapper
    {
        public static TipoDirectorResponse ToResponse(TipoDirectorResult dto) => new()
        {
        };

        public static IEnumerable<TipoDirectorResponse> ToListResponse(IEnumerable<TipoDirectorResult> items)
            => items.Select(ToResponse);
    }
}
