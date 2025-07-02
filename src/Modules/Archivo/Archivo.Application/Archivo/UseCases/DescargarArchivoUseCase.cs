using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Archivo.Application.Archivo.Services;

namespace Archivo.Application.Archivo.UseCases
{
    public class DescargarArchivoUseCase : IUseCase<string, Stream>
    {
        private readonly IStorageService _storageService;

        public DescargarArchivoUseCase(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public async Task<OneOf<ErrorBase, Stream>> ExecuteAsync(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                return ErrorBase.Validation("La URL está vacía o es inválida.");
            }

            try
            {
                var stream = await _storageService.DescargarArchivoAsync(url);
                return stream;
            }
            catch (Exception ex)
            {
                return ErrorBase.Unexpected($"Error al descargar el archivo: {ex.Message}");
            }
        }
    }
}
