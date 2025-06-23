using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Responses;

namespace Usuario.Presentation.User.Mappers
{
    public static class UserResponseMapper
    {
        public static UserResponse ToResponse(UserResult dto) => new()
        {
            nUsuarioId = dto.UsuarioId,
            sApellidosYNombres = dto.ApellidosYNombres,
            sCargo = dto.Cargo,
            sPerfil = dto.Perfil,
            bEstado = dto.Estado,
            dtFechaCreacion = dto.FechaCreacion,
            dtUltimaModificacion = dto.UltimaModificacion,
            sCorreo = dto.Correo,
        };


        public static IEnumerable<UserResponse> ToListResponse(IEnumerable<UserResult> items)
            => items.Select(ToResponse);
    }
}
