/*****
 * Nombre del archivo:  CrearCargoRequestMapper.cs
 * Descripción:         Clase encargada de mapear una solicitud de creación de cargo (`CrearCargoRequest`) a los parámetros necesarios para la base de datos (`CrearCargoParameters`).
 *                      Utiliza `ITimeProvider` para asignar la fecha de registro actual.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;

namespace Empresa.Application.Cargo.Mappers
{
    public class CrearCargoRequestMapper : IMapper<CrearCargoRequest, CrearCargoParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearCargoRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearCargoParameters Map(CrearCargoRequest source)
        {
            return new CrearCargoParameters
            {
                NombreCargo = source.sNombreCargo,
                UsuarioRegistroId = source.nUsuarioRegistro,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
