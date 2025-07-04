using Archivo.Application.Archivo.Dtos;
using Microsoft.AspNetCore.Http;

namespace Archivo.Application.Archivo.Services
{
    public interface IStorageService
    {
        public Task<string> SubirArchivoAsync(Stream stream, string rutaArchivo, string contentType);
        public Task<DataArchivoDto?> SubirPrueba(IFormFile file, string remotePath = "");
        public Task<Stream> DescargarArchivoAsync(string rutaCompleta);
    }
}
