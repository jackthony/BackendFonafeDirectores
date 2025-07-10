/***********
 * Nombre del archivo:  DistritoResponseMapper.cs
 * Descripción:         Mapper estático que transforma objetos de tipo DistritoResult
 *                      a respuestas del tipo DistritoResponse, utilizados en la capa de presentación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial de métodos de mapeo para distritos.
 ***********/

using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Responses;

namespace Empresa.Presentation.Ubigeo.Mappers
{
    public static class DistritoResponseMapper
    {
        public static DistritoResponse ToResponse(DistritoResult dto) => new()
        {
            sCode = dto.DistritoId.ToString("D4"),
            sName = dto.NombreDistrito,
            sProvinceCode = dto.ProvinciaId.ToString("D4")
        };

        public static IEnumerable<DistritoResponse> ToListResponse(IEnumerable<DistritoResult> items)
            => items.Select(ToResponse);
    }
}
