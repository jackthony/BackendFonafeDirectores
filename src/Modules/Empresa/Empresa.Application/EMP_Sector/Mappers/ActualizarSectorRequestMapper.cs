/*****
 * Nombre del archivo:  ActualizarSectorRequestMapper.cs
 * Descripción:         Mapeador que convierte un objeto ActualizarSectorRequest en
 *                      ActualizarSectorParameters, asignando propiedades para la actualización
 *                      de un sector, incluyendo usuario y fecha de modificación con la hora actual de Perú.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;
using Shared.Time;

namespace Empresa.Application.Sector.Mappers
{
    public class ActualizarSectorRequestMapper : IMapper<ActualizarSectorRequest, ActualizarSectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarSectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public ActualizarSectorParameters Map(ActualizarSectorRequest source)
        {
            return new ActualizarSectorParameters
            {
                SectorId = source.nIdSector,
                NombreSector = source.sNombreSector,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }
}
