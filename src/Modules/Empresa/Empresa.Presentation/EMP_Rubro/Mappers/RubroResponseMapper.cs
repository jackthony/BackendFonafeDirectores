/***********
 * Nombre del archivo:  RubroResponseMapper.cs
 * Descripción:         Clase estática responsable de mapear objetos RubroResult del dominio a RubroResponse 
 *                      utilizados en la capa de presentación. Incluye métodos para mapear uno o varios elementos.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación de métodos de mapeo para la entidad Rubro.
 ***********/

using Empresa.Domain.Rubro.Results;
using Empresa.Presentation.Rubro.Responses;

namespace Empresa.Presentation.Rubro.Mappers
{
    public static class RubroResponseMapper
    {
        public static RubroResponse ToResponse(RubroResult dto) => new()
        {
            nIdRubro = dto.RubroId,
            sNombreRubro = dto.NombreRubro,
            bActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacionId
        };

        public static IEnumerable<RubroResponse> ToListResponse(IEnumerable<RubroResult> items)
            => items.Select(ToResponse);
    }
}
