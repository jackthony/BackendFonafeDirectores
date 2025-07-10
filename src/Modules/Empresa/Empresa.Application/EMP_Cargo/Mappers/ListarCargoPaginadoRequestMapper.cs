/*****
 * Nombre del archivo:  ListarCargoPaginadoRequestMapper.cs
 * Descripción:         Clase encargada de mapear una solicitud de listado paginado de cargos (`ListarCargoPaginadoRequest`) a los parámetros necesarios para realizar la consulta paginada en la base de datos (`ListarCargoPaginadoParameters`).
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;

namespace Empresa.Application.Cargo.Mappers
{
    public class ListarCargoPaginadoRequestMapper : IMapper<ListarCargoPaginadoRequest, ListarCargoPaginadoParameters>
    {
        public ListarCargoPaginadoParameters Map(ListarCargoPaginadoRequest source)
        {
            return new ListarCargoPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                Estado = source.Estado,
                Nombre = source.Nombre,
            };
        }
    }
}
