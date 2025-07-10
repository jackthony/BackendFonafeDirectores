/***********
 * Nombre del archivo:  ModuloResponseMapper.cs
 * Descripción:         Clase estática encargada de mapear objetos de tipo ModuloResult
 *                      a objetos de respuesta ModuloResponse utilizados en la capa de presentación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del mapeador para módulos.
 ***********/

using Usuario.Presentation.Modulo.Responses;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Presentation.Modulo.Mappers
{
    public static class ModuloResponseMapper
    {
        public static ModuloResponse ToResponse(ModuloResult dto) => new()
        {
        };

        public static IEnumerable<ModuloResponse> ToListResponse(IEnumerable<ModuloResult> items)
            => items.Select(ToResponse);
    }
}
