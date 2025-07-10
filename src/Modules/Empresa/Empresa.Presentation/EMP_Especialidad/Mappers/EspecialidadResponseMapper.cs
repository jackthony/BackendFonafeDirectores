/***********
 * Nombre del archivo:  EspecialidadResponseMapper.cs
 * Descripción:         Clase estática que contiene métodos para mapear objetos
 *                      del tipo EspecialidadResult (modelo de dominio) a EspecialidadResponse
 *                      (DTO de presentación), incluyendo mapeo individual y de listas.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del mapper EspecialidadResponseMapper.
 ***********/

using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Responses;

namespace Empresa.Presentation.Especialidad.Mappers
{
    public static class EspecialidadResponseMapper
    {
        public static EspecialidadResponse ToResponse(EspecialidadResult dto) => new()
        {
            nIdEspecialidad = dto.EspecialidadId,
            sNombreEspecialidad = dto.NombreEspecialidad,
            bActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacionId
        };

        public static IEnumerable<EspecialidadResponse> ToListResponse(IEnumerable<EspecialidadResult> items)
            => items.Select(ToResponse);
    }
}
