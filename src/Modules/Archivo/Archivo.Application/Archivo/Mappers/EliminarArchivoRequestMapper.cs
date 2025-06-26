using Shared.Kernel.Interfaces;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;

namespace Archivo.Application.Archivo.Mappers
{
    public class EliminarArchivoRequestMapper : IMapper<EliminarArchivoRequest, EliminarArchivoParameters>
    {
        public EliminarArchivoParameters Map(EliminarArchivoRequest source)
        {
            return new EliminarArchivoParameters
            {
            };
        }
    }
}
