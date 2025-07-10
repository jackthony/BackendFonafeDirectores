/*****
 * Nombre de clase:     ActualizarMinisterioRequestMapper
 * Descripción:         Mapper encargado de transformar el DTO ActualizarMinisterioRequest
 *                      en el parámetro ActualizarMinisterioParameters utilizado en la capa de dominio.
 *                      Utiliza ITimeProvider para asignar la fecha de modificación con la hora actual de Perú.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para realizar el mapeo entre el request de actualización y los parámetros de dominio.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;
using Shared.Time;

namespace Empresa.Application.Ministerio.Mappers
{
    public class ActualizarMinisterioRequestMapper : IMapper<ActualizarMinisterioRequest, ActualizarMinisterioParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarMinisterioRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public ActualizarMinisterioParameters Map(ActualizarMinisterioRequest source)
        {
            return new ActualizarMinisterioParameters
            {
                MinisterioId = source.nIdMinisterio,
                NombreMinisterio = source.sNombreMinisterio,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }
}
