/*****
 * Nombre de clase:     ActualizarEspecialidadRequestMapper
 * Descripción:         Mapeador que convierte un DTO ActualizarEspecialidadRequest
 *                      en los parámetros necesarios para actualizar una especialidad,
 *                      asignando el ID, nombre, usuario que modifica y la fecha actual en zona Perú.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase generada para manejar el mapeo en la actualización de especialidades.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;
using Shared.Time;

namespace Empresa.Application.Especialidad.Mappers
{
    public class ActualizarEspecialidadRequestMapper : IMapper<ActualizarEspecialidadRequest, ActualizarEspecialidadParameters>
    {
        private readonly ITimeProvider _timeProvider;
        public ActualizarEspecialidadRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }
        public ActualizarEspecialidadParameters Map(ActualizarEspecialidadRequest source)
        {
            return new ActualizarEspecialidadParameters
            {
                EspecialidadId = source.nIdEspecialidad,
                NombreEspecialidad = source.sNombreEspecialidad,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = _timeProvider.NowPeru
            };
        }
    }
}
