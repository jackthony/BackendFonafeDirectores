using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User.Mappers
{
    public static class UserResponseMapper
    {
        public static UserResponse ToResponse(UserResult dto) => new()
        {
            nUsuarioId = dto.UsuarioId,
            sUsername = dto.Username,
            sCorreoElectronico = dto.CorreoElectronico,
            sApellidoPaterno = dto.ApellidoPaterno,
            sApellidoMaterno = dto.ApellidoMaterno,
            sNombres = dto.Nombres,
            nEstado = dto.Estado,
            bIsActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistroId = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacionId = dto.UsuarioModificacionId,
        };


        public static IEnumerable<UserResponse> ToListResponse(IEnumerable<UserResult> items)
            => items.Select(ToResponse);
    }
}
