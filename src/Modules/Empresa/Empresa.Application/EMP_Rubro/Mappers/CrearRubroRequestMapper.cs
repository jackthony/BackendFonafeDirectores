/*****
 * Nombre de clase:     CrearRubroRequestMapper
 * Descripción:         Mapper encargado de transformar el DTO CrearRubroRequest
 *                      en el parámetro CrearRubroParameters utilizado en la capa de dominio.
 *                      Utiliza ITimeProvider para asignar la fecha de registro con la hora actual de Perú.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para realizar el mapeo entre el request de creación y los parámetros de dominio.
 *****/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;

namespace Empresa.Application.Rubro.Mappers
{
    public class CrearRubroRequestMapper : IMapper<CrearRubroRequest, CrearRubroParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearRubroRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearRubroParameters Map(CrearRubroRequest source)
        {
            return new CrearRubroParameters
            {
                NombreRubro = source.sNombreRubro,
                UsuarioRegistroId = source.nUsuarioRegistro,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
