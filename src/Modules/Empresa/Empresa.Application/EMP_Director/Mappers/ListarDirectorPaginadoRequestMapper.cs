/*****
 * Nombre del archivo:  ListarDirectorPaginadoRequestMapper.cs
 * Descripción:         Clase que mapea una solicitud paginada de listado de directores (`ListarDirectorPaginadoRequest`) a los parámetros necesarios para la base de datos (`ListarDirectorPaginadoParameters`).
 *                      Incluye propiedades como `Nombre`, `Estado`, `nIdEmpresa`, `Page` y `PageSize` para aplicar filtros y realizar la paginación de los resultados.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;

namespace Empresa.Application.Director.Mappers
{
    public class ListarDirectorPaginadoRequestMapper : IMapper<ListarDirectorPaginadoRequest, ListarDirectorPaginadoParameters>
    {
        public ListarDirectorPaginadoParameters Map(ListarDirectorPaginadoRequest source)
        {
            return new ListarDirectorPaginadoParameters 
            {
                Nombre = source.Nombre,
                Estado = source.Estado,
                nIdEmpresa = source.nIdEmpresa,
                Page = source.Page,
                PageSize = source.PageSize,
            };
        }
    }
}
