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
            };
        }
    }
}
