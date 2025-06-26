using Usuario.Domain.Rol.Results;
using Usuario.Presentation.Rol.Responses;

namespace Usuario.Presentation.Rol.Mappers
{
    public static class RolResponseMapper
    {
        public static RolResponse ToResponse(RolResult dto) => new()
        {
            nRolId = dto.RolId,
            sNombreRol = dto.NombreRol,
            bActivo = dto.Activo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistroId = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacionId = dto.UsuarioModificacionId
        };

        public static IEnumerable<RolResponse> ToListResponse(IEnumerable<RolResult> items)
            => items.Select(ToResponse);
    }
}
