/*****
 * Nombre del archivo:  EliminarSectorRequestMapper.cs
 * Descripción:         Mapeador que convierte un objeto EliminarSectorRequest en
 *                      EliminarSectorParameters, asignando datos para la eliminación
 *                      de un sector, incluyendo usuario y fecha de modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;

namespace Empresa.Application.Sector.Mappers
{
    public class EliminarSectorRequestMapper : IMapper<EliminarSectorRequest, EliminarSectorParameters>
    {
        public EliminarSectorParameters Map(EliminarSectorRequest source)
        {
            return new EliminarSectorParameters
            {
                SectorId = source.nIdSector,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = DateTime.UtcNow
            };
        }
    }
}
