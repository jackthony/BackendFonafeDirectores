/*****
 * Nombre del archivo:  ListarSectorPaginadoRequestMapper.cs
 * Descripción:         Mapeador que convierte un objeto ListarSectorPaginadoRequest en
 *                      ListarSectorPaginadoParameters, trasladando propiedades de paginación
 *                      y filtros para su uso en el dominio.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;

namespace Empresa.Application.Sector.Mappers
{
    public class ListarSectorPaginadoRequestMapper : IMapper<ListarSectorPaginadoRequest, ListarSectorPaginadoParameters>
    {
        public ListarSectorPaginadoParameters Map(ListarSectorPaginadoRequest source)
        {
            return new ListarSectorPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                Estado = source.Estado,
                Nombre = source.Nombre,
            };
        }
    }
}
