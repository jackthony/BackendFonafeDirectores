/***********
 * Nombre del archivo:  DepartamentoResponseMapper.cs
 * Descripción:         Mapper estático responsable de convertir objetos DepartamentoResult
 *                      en respuestas DepartamentoResponse para su uso en la capa de presentación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial de los métodos de mapeo para departamentos.
 ***********/

using Empresa.Domain.Ubigeo.Results;
using Empresa.Presentation.Ubigeo.Responses;

namespace Empresa.Presentation.Ubigeo.Mappers
{
    public static class DepartamentoResponseMapper
    {
        public static DepartamentoResponse ToResponse(DepartamentoResult dto) => new()
        {
            sCode = dto.DepartamentoId.ToString("D4"),
            sName = dto.NombreDepartamento
        };

        public static IEnumerable<DepartamentoResponse> ToListResponse(IEnumerable<DepartamentoResult> items)
            => items.Select(ToResponse);
    }
}
