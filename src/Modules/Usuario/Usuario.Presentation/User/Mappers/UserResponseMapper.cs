using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User.Mappers
{
    public static class UserResponseMapper
    {
        public static UserResponse ToResponse(UserResult dto) => new()
        {
            nIdUsuario = dto.IdUsuario,
            sApellidoPaterno = dto.ApellidoPaterno,
            sApellidoMaterno = dto.ApellidoMaterno,
            sNombres = dto.Nombres,
            nIdCargo = dto.IdCargo,
            nIdRol = dto.IdRol,
            sCorreoElectronico = dto.CorreoElectronico,
            nEstado = dto.Estado,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistro,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacion,
            sCargoDescripcion = dto.CargoDescripcion,
            sPerfilDescripcion = dto.PerfilDescripcion,
            sEstadoDescripcion = dto.EstadoDescripcion
        };


        public static IEnumerable<UserResponse> ToListResponse(IEnumerable<UserResult> items)
            => items.Select(ToResponse);
    }
}
