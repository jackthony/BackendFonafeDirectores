/***********
 * Nombre del archivo:  ProvinciaResponseMapper.cs
 * Descripción:         Mapper estático que transforma objetos de tipo ProvinciaResult
 *                      a respuestas del tipo ProvinciaResponse, utilizados en la capa de presentación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial de métodos de mapeo para provincias.
 ***********/

using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Responses;

namespace Empresa.Presentation.Ubigeo.Mappers
{
    public static class ProvinciaResponseMapper
    {
        public static ProvinciaResponse ToResponse(ProvinciaResult dto) => new()
        {
            sCode = dto.ProvinciaId.ToString("D4"),
            sName = dto.NombreProvincia,
            sDepartmentCode = dto.DepartamentoId.ToString("D4")
        };

        public static IEnumerable<ProvinciaResponse> ToListResponse(IEnumerable<ProvinciaResult> items)
            => items.Select(ToResponse);
    }
}
