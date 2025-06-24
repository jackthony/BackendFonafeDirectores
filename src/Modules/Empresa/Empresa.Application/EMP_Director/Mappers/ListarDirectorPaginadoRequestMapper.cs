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
