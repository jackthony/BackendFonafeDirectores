using Shared.Kernel.Interfaces;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Parameters;

namespace Empresa.Application.Especialidad.Mappers
{
    public class ListarEspecialidadRequestMapper : IMapper<ListarEspecialidadRequest, ListarEspecialidadParameters>
    {
        public ListarEspecialidadParameters Map(ListarEspecialidadRequest source)
        {
            return new ListarEspecialidadParameters
            {
            };
        }
    }
}
