namespace Archivo.Application.Archivo.Services
{
    public interface IStorageService
    {
        public Task<string> SubirArchivoAsync(Stream stream, string rutaArchivo, string contentType);
    }
}
