/***********
 * Nombre del archivo:  RolResponseMapper.cs
 * Descripción:         Clase estática encargada de mapear objetos de dominio (RolResult)
 *                      a objetos de presentación (RolResponse), tanto de forma individual
 *                      como en listas.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del mapeo de resultados de rol.
 ***********/

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
