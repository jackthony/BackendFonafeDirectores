/*****
 * Nombre del archivo:  CrearTipoDirectorRequestMapper.cs
 * Descripción:         Mapeador que transforma un objeto CrearTipoDirectorRequest en 
 *                      CrearTipoDirectorParameters, incluyendo la fecha actual de Perú
 *                      mediante el proveedor de tiempo inyectado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Interfaces;
using Shared.Time;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;

namespace Empresa.Application.TipoDirector.Mappers
{
    public class CrearTipoDirectorRequestMapper : IMapper<CrearTipoDirectorRequest, CrearTipoDirectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearTipoDirectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearTipoDirectorParameters Map(CrearTipoDirectorRequest source)
        {
            return new CrearTipoDirectorParameters
            {
                NombreTipoDirector = source.sNombreTipoDirector,
                UsuarioRegistroId = source.nUsuarioRegistro,
                FechaRegistro = _timeProvider.NowPeru
            };
        }
    }
}
