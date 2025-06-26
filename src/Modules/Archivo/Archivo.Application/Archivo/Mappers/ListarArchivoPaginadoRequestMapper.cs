using Shared.Kernel.Interfaces;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;

namespace Archivo.Application.Archivo.Mappers
{
    public class ListarArchivoPaginadoRequestMapper : IMapper<ListarArchivoPaginadoRequest, ListarArchivoPaginadoParameters>
    {
        public ListarArchivoPaginadoParameters Map(ListarArchivoPaginadoRequest source)
        {
            return new ListarArchivoPaginadoParameters
            {
            };
        }
    }
}
