/*****
 * Nombre del archivo:  BunnyStorageService.cs
 * Descripción:         Implementación del servicio `IStorageService` para interactuar con Bunny CDN y gestionar archivos en el almacenamiento. 
 *                      Incluye métodos para subir y descargar archivos, utilizando las opciones de configuración proporcionadas por `BunnyStorageOptions`.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Api.Settings;
using Archivo.Application.Archivo.Dtos;
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

        public async Task<Stream> DescargarArchivoAsync(string rutaCompleta)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, rutaCompleta);
                request.Headers.Add("AccessKey", _options.ApiKey);

                var response = await _httpClient.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Error al descargar el archivo: {response.StatusCode}");
                }

                var stream = await response.Content.ReadAsStreamAsync();
                return stream;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al descargar el archivo", ex);
            }
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

        public async Task<DataArchivoDto?> SubirPrueba(IFormFile file, string remotePath = "")
        {
            if (file == null || file.Length == 0)
                return null;

            try
            {
                using var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("AccessKey", _options.ApiKey);

                string fileName = string.IsNullOrEmpty(remotePath) ? file.FileName : remotePath;
                string uploadUrl = $"{_options.BaseUrl}/{_options.StorageZone}/{fileName.TrimStart('/')}";

                using var fileStream = file.OpenReadStream();
                using var content = new StreamContent(fileStream);

                var response = await httpClient.PutAsync(uploadUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    return new DataArchivoDto
                    {
                        Url = uploadUrl,
                        Name = fileName
                    };
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

    }
}
