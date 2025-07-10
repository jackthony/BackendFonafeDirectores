/*****
 * Nombre de clase:     ListarMinisterioPaginadoRequestMapper
 * Descripción:         Mapper encargado de transformar el DTO ListarMinisterioPaginadoRequest
 *                      en el parámetro ListarMinisterioPaginadoParameters utilizado en la capa de dominio.
 *                      Realiza el mapeo de datos relacionados a paginación y filtros como nombre y estado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para realizar el mapeo entre el request paginado y los parámetros de dominio.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;

namespace Empresa.Application.Ministerio.Mappers
{
    public class ListarMinisterioPaginadoRequestMapper : IMapper<ListarMinisterioPaginadoRequest, ListarMinisterioPaginadoParameters>
    {
        public ListarMinisterioPaginadoParameters Map(ListarMinisterioPaginadoRequest source)
        {
            return new ListarMinisterioPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                Estado = source.Estado,
                Nombre = source.Nombre,
            };
        }
    }
}
