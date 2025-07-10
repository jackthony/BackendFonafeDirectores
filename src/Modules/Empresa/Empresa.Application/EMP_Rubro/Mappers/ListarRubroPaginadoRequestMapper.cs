/*****
 * Nombre de clase:     ListarRubroPaginadoRequestMapper
 * Descripción:         Mapper encargado de transformar el DTO ListarRubroPaginadoRequest
 *                      en el parámetro ListarRubroPaginadoParameters utilizado en la capa de dominio.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para realizar el mapeo entre el request de aplicación y los parámetros de dominio.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;

namespace Empresa.Application.Rubro.Mappers
{
    public class ListarRubroPaginadoRequestMapper : IMapper<ListarRubroPaginadoRequest, ListarRubroPaginadoParameters>
    {
        public ListarRubroPaginadoParameters Map(ListarRubroPaginadoRequest source)
        {
            return new ListarRubroPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                Estado = source.Estado,
                Nombre = source.Nombre,
            };
        }
    }
}

using Shared.Kernel.Interfaces;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;

namespace Empresa.Application.Rubro.Mappers
{
    public class ListarRubroPaginadoRequestMapper : IMapper<ListarRubroPaginadoRequest, ListarRubroPaginadoParameters>
    {
        public ListarRubroPaginadoParameters Map(ListarRubroPaginadoRequest source)
        {
            return new ListarRubroPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                Estado = source.Estado,
                Nombre = source.Nombre,
            };
        }
    }
}
