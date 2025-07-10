/*****
 * Nombre del archivo:  ListarTipoDirectorPaginadoRequestMapper.cs
 * Descripción:         Mapeador que convierte un objeto ListarTipoDirectorPaginadoRequest en 
 *                      ListarTipoDirectorPaginadoParameters, permitiendo aplicar filtros y paginación
 *                      en la consulta de tipos de director.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;

namespace Empresa.Application.TipoDirector.Mappers
{
    public class ListarTipoDirectorPaginadoRequestMapper : IMapper<ListarTipoDirectorPaginadoRequest, ListarTipoDirectorPaginadoParameters>
    {
        public ListarTipoDirectorPaginadoParameters Map(ListarTipoDirectorPaginadoRequest source)
        {
            return new ListarTipoDirectorPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                Estado = source.Estado,
                Nombre = source.Nombre,
            };
        }
    }
}
