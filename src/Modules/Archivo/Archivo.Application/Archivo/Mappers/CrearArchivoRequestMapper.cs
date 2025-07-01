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
            var result = new CrearArchivoParameters
            {
                IsDocumento = source.IsDocumento,
                Nombre = source.Nombre,
                CarpetaPadreId = source.CarpetaPadreId,
                UsuarioRegistroId = source.UsuarioRegistroId,
                FechaRegistro = _timeProvider.NowPeru,
                EmpresaId = source.EmpresaId,
            };

            if (source.IsDocumento && source.Archivo != null)
            {
                result.Peso = source.Archivo.Length;
                result.TipoMime = source.Archivo.ContentType;
            }

            return result;
        }
    }
}
