/*****
 * Nombre del archivo:  ActualizarTipoDirectorRequestMapper.cs
 * Descripción:         Mapeador que convierte un objeto ActualizarTipoDirectorRequest en 
 *                      ActualizarTipoDirectorParameters, incluyendo la fecha de modificación
 *                      basada en la hora actual de Perú mediante ITimeProvider.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;
using Shared.Time;

namespace Empresa.Application.TipoDirector.Mappers
{
    public class ActualizarTipoDirectorRequestMapper : IMapper<ActualizarTipoDirectorRequest, ActualizarTipoDirectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarTipoDirectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public ActualizarTipoDirectorParameters Map(ActualizarTipoDirectorRequest source)
        {
            return new ActualizarTipoDirectorParameters
            {
                TipoDirectorId = source.nIdTipoDirector,
                NombreTipoDirector = source.sNombreTipoDirector,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }
}
