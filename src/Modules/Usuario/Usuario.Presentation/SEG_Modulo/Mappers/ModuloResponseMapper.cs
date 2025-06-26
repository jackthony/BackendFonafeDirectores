using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Responses;

namespace Usuario.Presentation.Modulo.Mappers
{
    public static class ModuloResponseMapper
    {
        public static ModuloResponse ToResponse(ModuloResult dto) => new()
        {
        };

        public static IEnumerable<ModuloResponse> ToListResponse(IEnumerable<ModuloResult> items)
            => items.Select(ToResponse);
    }
}
