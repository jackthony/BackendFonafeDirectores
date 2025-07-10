/***********
 * Nombre del archivo:  SectorResponseMapper.cs
 * Descripción:         Clase estática responsable de mapear entidades del dominio (`SectorResult`)
 *                      a DTOs de respuesta (`SectorResponse`) para la capa de presentación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del mapeador de sectores.
 ***********/

using Empresa.Domain.Sector.Results;
using Empresa.Presentation.Sector.Responses;

namespace Empresa.Presentation.Sector.Mappers
{
    public static class SectorResponseMapper
    {
        public static SectorResponse ToResponse(SectorResult dto) => new()
        {
            nIdSector = dto.SectorId,
            sNombreSector = dto.NombreSector,
            bActivo = dto.IsActivo,
            dtFechaRegistro = dto.FechaRegistro,
            nUsuarioRegistro = dto.UsuarioRegistroId,
            dtFechaModificacion = dto.FechaModificacion,
            nUsuarioModificacion = dto.UsuarioModificacionId
        };

        public static IEnumerable<SectorResponse> ToListResponse(IEnumerable<SectorResult> items)
            => items.Select(ToResponse);
    }
}
