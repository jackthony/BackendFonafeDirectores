/***********
 * Nombre del archivo:  MinisterioResponseMapper.cs
 * Descripción:         Clase estática que mapea objetos de dominio MinisterioResult
 *                      a objetos de presentación MinisterioResponse, incluyendo 
 *                      métodos para mapeo individual y listas.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del mapeador para la entidad Ministerio.
 ***********/

using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Responses;

namespace Empresa.Presentation.Ministerio.Mappers
{
    public static class MinisterioResponseMapper
    {
        public static MinisterioResponse ToResponse(MinisterioResult dto) => new()
        {
            nIdMinisterio = dto.MinisterioId,
            sNombreMinisterio = dto.NombreMinisterio,
            bActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacionId
        };

        public static IEnumerable<MinisterioResponse> ToListResponse(IEnumerable<MinisterioResult> items)
            => items.Select(ToResponse);
    }
}
