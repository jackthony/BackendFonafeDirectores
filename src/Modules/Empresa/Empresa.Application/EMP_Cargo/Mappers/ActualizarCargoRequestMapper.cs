/*****
 * Nombre del archivo:  ActualizarCargoRequestMapper.cs
 * Descripción:         Clase encargada de mapear una solicitud de actualización de cargo (`ActualizarCargoRequest`) a los parámetros necesarios para la base de datos (`ActualizarCargoParameters`).
 *                      Utiliza `ITimeProvider` para asignar la fecha de modificación actual.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;
using Shared.Time;

namespace Empresa.Application.Cargo.Mappers
{
    public class ActualizarCargoRequestMapper : IMapper<ActualizarCargoRequest, ActualizarCargoParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarCargoRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public ActualizarCargoParameters Map(ActualizarCargoRequest source)
        {
            return new ActualizarCargoParameters
            {
                CargoId = source.nIdCargo,
                NombreCargo = source.sNombreCargo,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }

}
