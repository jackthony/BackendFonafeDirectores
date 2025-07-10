/*****
 * Nombre del archivo:  EliminarDirectorRequestMapper.cs
 * Descripción:         Clase que mapea una solicitud de eliminación de director (`EliminarDirectorRequest`) a los parámetros necesarios para la base de datos (`EliminarDirectorParameters`).
 *                      Utiliza el servicio `ITimeProvider` para asignar la fecha de modificación al objeto de parámetros.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;
using Shared.Time;

namespace Empresa.Application.Director.Mappers
{
    public class EliminarDirectorRequestMapper : IMapper<EliminarDirectorRequest, EliminarDirectorParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public EliminarDirectorRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }
        public EliminarDirectorParameters Map(EliminarDirectorRequest source)
        {
            return new EliminarDirectorParameters
            {
                nDirectorId = source.nDirectorId,
                dtFechaModificacion = _timeProvider.NowPeru,
                nUsuarioModificacionId = source.nUsuarioModificacionId
            };
        }
    }
}
