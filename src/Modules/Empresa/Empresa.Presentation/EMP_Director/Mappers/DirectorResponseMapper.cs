using Empresa.Domain.Director.Results;
using Empresa.Presentation.Director.Responses;

namespace Empresa.Presentation.Director.Mappers
{
    public static class DirectorResponseMapper
    {
        public static DirectorResponse ToResponse(DirectorResult dto) => new()
        {
        };

        public static IEnumerable<DirectorResponse> ToListResponse(IEnumerable<DirectorResult> items)
            => items.Select(ToResponse);
    }
}
