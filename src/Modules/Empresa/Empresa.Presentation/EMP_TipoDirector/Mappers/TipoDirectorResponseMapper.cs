/***********
 * Nombre del archivo:  TipoDirectorResponseMapper.cs
 * Descripción:         Clase de mapeo encargada de convertir objetos de dominio TipoDirectorResult
 *                      en respuestas DTO TipoDirectorResponse que serán expuestas al cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del mapper para entidades TipoDirector.
 ***********/

using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Responses;

namespace Empresa.Presentation.TipoDirector.Mappers
{
    public static class TipoDirectorResponseMapper
    {
        public static TipoDirectorResponse ToResponse(TipoDirectorResult dto) => new()
        {
            nIdTipoDirector = dto.TipoDirectorId,
            sNombreTipoDirector = dto.NombreTipoDirector,
            bActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacionId
        };

        public static IEnumerable<TipoDirectorResponse> ToListResponse(IEnumerable<TipoDirectorResult> items)
            => items.Select(ToResponse);
    }
}
