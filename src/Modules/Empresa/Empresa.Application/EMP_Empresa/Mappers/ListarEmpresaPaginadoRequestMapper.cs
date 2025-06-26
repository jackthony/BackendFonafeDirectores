using Shared.Kernel.Interfaces;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;

namespace Empresa.Application.Empresa.Mappers
{
    public class ListarEmpresaPaginadoRequestMapper : IMapper<ListarEmpresaPaginadoRequest, ListarEmpresaPaginadoParameters>
    {
        public ListarEmpresaPaginadoParameters Map(ListarEmpresaPaginadoRequest source)
        {
            return new ListarEmpresaPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                RazonSocial = source.sRazonSocial,
                Estado = source.bEstado
            };
        }
    }
}
