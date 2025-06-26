using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Provincia.Mappers
{
    public class ListarProvinciaRequestMapper : IMapper<ListarProvinciaRequest, ListarProvinciaParameters>
    {
        public ListarProvinciaParameters Map(ListarProvinciaRequest source)
        {
            return new ListarProvinciaParameters
            {
                DepartamentoId = int.Parse(source.sCode),
                Nombre = source.sNombre
            };
        }
    }
}
