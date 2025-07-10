/*****
 * Nombre de clase:     CrearMinisterioRequestMapper
 * Descripción:         Mapper encargado de transformar el DTO CrearMinisterioRequest
 *                      en el parámetro CrearMinisterioParameters utilizado en la capa de dominio.
 *                      Utiliza ITimeProvider para asignar la fecha de registro con la hora actual de Perú.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para realizar el mapeo entre el request de creación y los parámetros de dominio.
 *****/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;

namespace Empresa.Application.Ministerio.Mappers
{
    public class CrearMinisterioRequestMapper : IMapper<CrearMinisterioRequest, CrearMinisterioParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearMinisterioRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearMinisterioParameters Map(CrearMinisterioRequest source)
        {
            return new CrearMinisterioParameters
            {
                NombreMinisterio = source.sNombreMinisterio,
                UsuarioRegistroId = source.nUsuarioRegistroId,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
