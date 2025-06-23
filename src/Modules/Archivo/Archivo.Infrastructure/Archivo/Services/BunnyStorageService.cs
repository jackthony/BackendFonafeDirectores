using Api.Settings;
using Archivo.Application.Archivo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace Archivo.Infrastructure.Archivo.Services
{
    public class BunnyStorageService : IStorageService
    {
        private readonly BunnyStorageOptions _options;
        private readonly HttpClient _httpClient;

        public BunnyStorageService(IOptions<BunnyStorageOptions> options)
        {
            _options = options.Value;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("AccessKey", _options.ApiKey);
        }

        public async Task<string> SubirArchivoAsync(Stream stream, string rutaArchivo, string contentType)
        {
            var url = $"{_options.BaseUrl}/{_options.StorageZone}/{rutaArchivo}";

            using var content = new StreamContent(stream);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);

            var response = await _httpClient.PutAsync(url, content);

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error al subir archivo: {response.StatusCode}");

            return $"https://{_options.StorageZone}.b-cdn.net/{rutaArchivo}";
        }

        public async Task<string> SubirPrueba(IFormFile file, string remotePath = "")
        {
            if (file == null || file.Length == 0)
            {
                return "";
            }

            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("AccessKey", _options.ApiKey);

                    // Si no se especifica ruta remota, usamos el nombre original
                    if (string.IsNullOrEmpty(remotePath))
                    {
                        remotePath = file.FileName;
                    }

                    // Construir la URL de destino
                    string uploadUrl = $"{_options.BaseUrl}/{_options.StorageZone}/{remotePath.TrimStart('/')}";

                    // Leer el archivo subido
                    using (var fileStream = file.OpenReadStream())
                    using (var content = new StreamContent(fileStream))
                    {
                        // Enviar el archivo a Bunny
                        var response = await httpClient.PutAsync(uploadUrl, content);

                        if (response.IsSuccessStatusCode)
                        {
                            return $"https://{_options.StorageZone}.b-cdn.net/{remotePath}";
                        }
                        else
                        {
                            return "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
