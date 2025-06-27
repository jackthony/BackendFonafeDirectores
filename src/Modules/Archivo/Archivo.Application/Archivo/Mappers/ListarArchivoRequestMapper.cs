using Shared.Kernel.Interfaces;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;

namespace Archivo.Application.Archivo.Mappers
{
    public class ListarArchivoRequestMapper : IMapper<ListarArchivoRequest, ListarArchivoParameters>
    {
        public ListarArchivoParameters Map(ListarArchivoRequest source)
        {
            return new ListarArchivoParameters
            {
            };
        }
    }
}
