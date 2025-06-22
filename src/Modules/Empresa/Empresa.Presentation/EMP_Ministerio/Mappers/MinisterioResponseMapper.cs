using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Responses;

namespace Empresa.Presentation.Ministerio.Mappers
{
    public static class MinisterioResponseMapper
    {
        public static MinisterioResponse ToResponse(MinisterioResult dto) => new()
        {
        };

        public static IEnumerable<MinisterioResponse> ToListResponse(IEnumerable<MinisterioResult> items)
            => items.Select(ToResponse);
    }
}
