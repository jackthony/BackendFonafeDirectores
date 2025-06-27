using Shared.Kernel.Interfaces;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;

namespace Archivo.Application.Archivo.Mappers
{
    public class ActualizarArchivoRequestMapper : IMapper<ActualizarArchivoRequest, ActualizarArchivoParameters>
    {
        public ActualizarArchivoParameters Map(ActualizarArchivoRequest source)
        {
            return new ActualizarArchivoParameters
            {
            };
        }
    }
}
