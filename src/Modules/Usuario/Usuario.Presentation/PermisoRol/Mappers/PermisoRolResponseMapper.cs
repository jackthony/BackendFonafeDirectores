/***********
 * Nombre del archivo:  PermisoRolResponseMapper.cs
 * Descripción:         Mapeador estático que convierte entidades del dominio (PermisoRolResult)
 *                      en respuestas del cliente (PermisoRolResponse), tanto individuales como listas.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Estructura base del mapeador creada. Falta completar el método ToResponse.
 ***********/

using Usuario.Domain.PermisoRol.Results;
using Usuario.Presentation.PermisoRol.Responses;

namespace Usuario.Presentation.PermisoRol.Mappers
{
    public static class PermisoRolResponseMapper
    {
        public static PermisoRolResponse ToResponse(PermisoRolResult dto) => new()
        {

        };

        public static IEnumerable<PermisoRolResponse> ToListResponse(IEnumerable<PermisoRolResult> items)
            => items.Select(ToResponse);
    }
}
