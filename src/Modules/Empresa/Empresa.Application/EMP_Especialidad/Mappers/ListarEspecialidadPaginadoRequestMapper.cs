/*****
 * Nombre de clase:     ListarEspecialidadPaginadoRequestMapper
 * Descripción:         Mapeador que convierte un DTO de solicitud paginada ListarEspecialidadPaginadoRequest
 *                      en los parámetros necesarios para la consulta paginada ListarEspecialidadPaginadoParameters.
 *                      Mapea las propiedades de paginación, estado y nombre para filtrado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase generada para manejo de solicitudes paginadas de especialidades.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;

namespace Empresa.Application.Especialidad.Mappers
{
    public class ListarEspecialidadPaginadoRequestMapper : IMapper<ListarEspecialidadPaginadoRequest, ListarEspecialidadPaginadoParameters>
    {
        public ListarEspecialidadPaginadoParameters Map(ListarEspecialidadPaginadoRequest source)
        {
            return new ListarEspecialidadPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                Estado = source.Estado,
                Nombre = source.Nombre,
            };
        }
    }
}
