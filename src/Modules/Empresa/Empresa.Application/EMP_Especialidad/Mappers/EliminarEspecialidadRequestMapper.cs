/*****
 * Nombre de clase:     EliminarEspecialidadRequestMapper
 * Descripción:         Mapeador que transforma un DTO de solicitud de eliminación
 *                      EliminarEspecialidadRequest en los parámetros necesarios para eliminar una especialidad,
 *                      incluyendo el Id de la especialidad, usuario que realiza la modificación y la fecha de modificación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase generada para manejar el mapeo en la eliminación de especialidades.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;

namespace Empresa.Application.Especialidad.Mappers
{
    public class EliminarEspecialidadRequestMapper : IMapper<EliminarEspecialidadRequest, EliminarEspecialidadParameters>
    {
        public EliminarEspecialidadParameters Map(EliminarEspecialidadRequest source)
        {
            return new EliminarEspecialidadParameters
            {
                EspecialidadId = source.nIdEspecialidad,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = DateTime.UtcNow
            };
        }
    }
}
