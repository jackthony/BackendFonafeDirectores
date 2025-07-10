/***********
 * Nombre del archivo:   UserResponseMapper.cs
 * Descripción:          Clase estática que proporciona métodos de mapeo para transformar objetos
 *                       'UserResult' del dominio a objetos 'UserResponse' de la capa de presentación.
 *                       Facilita la conversión de datos de usuario para ser expuestos a clientes.
 * Autor:                Daniel Alva
 * Fecha de creación:    09/07/2025
 * Última modificación:  09/07/2025 por Daniel Alva
 * Cambios recientes:    Creación inicial de la clase para el mapeo de resultados de usuario a respuestas.
 **********/

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
            nTipoPersonal = dto.nTipoPersonal,
            sCorreoElectronico = dto.CorreoElectronico,
            nEstado = dto.Estado,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistro,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacion,
            sCargoDescripcion = dto.CargoDescripcion,
            sPerfilDescripcion = dto.PerfilDescripcion,
            sEstadoDescripcion = dto.EstadoDescripcion,
            tipoPersonalDescripcion = dto.tipoPersonalDescripcion,
            sApellidosYNombres = $"{dto.ApellidoPaterno} {dto.ApellidoMaterno} {dto.Nombres}"
        };


        public static IEnumerable<UserResponse> ToListResponse(IEnumerable<UserResult> items)
            => items.Select(ToResponse);
    }
}
