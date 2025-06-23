using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Departamento.Mappers
{
    public class ListarDepartamentoRequestMapper : IMapper<ListarDepartamentoRequest, ListarDepartamentoParameters>
    {
        public ListarDepartamentoParameters Map(ListarDepartamentoRequest source)
        {
            return new ListarDepartamentoParameters
            {
                Nombre = source.sNombre,
            };
        }
    }
}
