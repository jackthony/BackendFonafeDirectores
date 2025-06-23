using Usuario.Domain.PermisoRol.Results;
using Usuario.Presentation.PermisoRol.Responses;

namespace Usuario.Presentation.PermisoRol.Mappers
{
    public static class PermisoRolResponseMapper
    {
        public static PermisoRolResponse ToResponse(PermisoRolResult dto) => new()
        {
        };

        public static IEnumerable<PermisoRolResponse> ToListResponse(IEnumerable<PermisoRolResult> items)
            => items.Select(ToResponse);
    }
}
