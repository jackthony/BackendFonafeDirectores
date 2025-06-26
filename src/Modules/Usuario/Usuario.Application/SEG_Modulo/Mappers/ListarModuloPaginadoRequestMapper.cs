using Shared.Kernel.Interfaces;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;

namespace Usuario.Application.Modulo.Mappers
{
    public class ListarModuloPaginadoRequestMapper : IMapper<ListarModuloPaginadoRequest, ListarModuloPaginadoParameters>
    {
        public ListarModuloPaginadoParameters Map(ListarModuloPaginadoRequest source)
        {
            return new ListarModuloPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
            };
        }
    }
}
