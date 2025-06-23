namespace Archivo.Application.Archivo.Services
{
    public interface IStorageServiceNet
    {
        public Task<string> UploadFileAsync(Stream fileStream, string fileName);
    }
}
