/*****
 * Nombre del archivo:  CrearSectorRequestMapper.cs
 * Descripción:         Mapeador que convierte un objeto CrearSectorRequest en
 *                      CrearSectorParameters, incluyendo asignación de nombre, usuario
 *                      de registro y fecha de registro con la hora actual de Perú.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;

namespace Empresa.Application.Sector.Mappers
{
    public class CrearSectorRequestMapper : IMapper<CrearSectorRequest, CrearSectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearSectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearSectorParameters Map(CrearSectorRequest source)
        {
            return new CrearSectorParameters
            {
                NombreSector = source.sNombreSector,
                UsuarioRegistroId = source.nUsuarioRegistro,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
