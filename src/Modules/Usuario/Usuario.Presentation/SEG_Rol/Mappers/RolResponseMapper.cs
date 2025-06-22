using Usuario.Domain.Rol.Results;
using Usuario.Presentation.Rol.Responses;

namespace Usuario.Presentation.Rol.Mappers
{
    public static class RolResponseMapper
    {
        public static RolResponse ToResponse(RolResult dto) => new()
        {
        };

        public static IEnumerable<RolResponse> ToListResponse(IEnumerable<RolResult> items)
            => items.Select(ToResponse);
    }
}
