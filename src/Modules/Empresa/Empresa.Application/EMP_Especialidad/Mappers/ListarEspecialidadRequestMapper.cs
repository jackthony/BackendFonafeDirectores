/*****
 * Nombre de clase:     ListarEspecialidadRequestMapper
 * Descripción:         Mapeador que convierte un DTO de solicitud ListarEspecialidadRequest
 *                      en los parámetros necesarios para la consulta ListarEspecialidadParameters.
 *                      Actualmente no realiza mapeos específicos ya que la petición no tiene filtros.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase generada como base para futuros mapeos de solicitud de listado de especialidades.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;

namespace Empresa.Application.Especialidad.Mappers
{
    public class ListarEspecialidadRequestMapper : IMapper<ListarEspecialidadRequest, ListarEspecialidadParameters>
    {
        public ListarEspecialidadParameters Map(ListarEspecialidadRequest source)
        {
            return new ListarEspecialidadParameters
            {
            };
        }
    }
}
