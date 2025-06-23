using Shared.Kernel.Interfaces;
using Shared.Time;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;

namespace Archivo.Application.Archivo.Mappers
{
    public class CrearArchivoRequestMapper : IMapper<CrearArchivoRequest, CrearArchivoParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public CrearArchivoRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public CrearArchivoParameters Map(CrearArchivoRequest source)
        {
            return new CrearArchivoParameters
            {
            };
        }
    }
}
