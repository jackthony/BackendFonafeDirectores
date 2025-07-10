/*****
 * Nombre de clase:     ActualizarRubroRequestMapper
 * Descripción:         Mapper encargado de transformar el DTO ActualizarRubroRequest
 *                      en el parámetro ActualizarRubroParameters utilizado en la capa de dominio.
 *                      Utiliza ITimeProvider para asignar la fecha de modificación con la hora actual de Perú.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para realizar el mapeo entre el request de actualización y los parámetros de dominio.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;
using Shared.Time;

namespace Empresa.Application.Rubro.Mappers
{
    public class ActualizarRubroRequestMapper : IMapper<ActualizarRubroRequest, ActualizarRubroParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public ActualizarRubroRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public ActualizarRubroParameters Map(ActualizarRubroRequest source)
        {
            return new ActualizarRubroParameters
            {
                RubroId = source.nIdRubro,
                NombreRubro = source.sNombreRubro,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }
}
