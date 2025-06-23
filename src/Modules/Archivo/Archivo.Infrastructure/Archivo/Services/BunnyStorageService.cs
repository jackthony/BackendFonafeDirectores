using Archivo.Application.Archivo.Services;
using Microsoft.Extensions.Configuration;

namespace Archivo.Infrastructure.Archivo.Services
{
    public class BunnyStorageService : IStorageServiceNet
    {
        private readonly HttpClient _httpClient;
        private readonly string _zoneName;
        private readonly string _accessKey;
        private readonly string _storageBaseUrl;
        public BunnyStorageService(IConfiguration configuration, HttpClient httpClient)
        {
            _httpClient = httpClient;
            _zoneName = configuration["BunnyStorage:ZoneName"]!;
            _accessKey = configuration["BunnyStorage:AccessKey"]!;
            _storageBaseUrl = $"https://storage.bunnycdn.com/{_zoneName}";
        }

        public async Task<string> UploadFileAsync(Stream fileStream, string fileName)
        {
            var uploadUrl = $"{_storageBaseUrl}/{fileName}";
            using var content = new StreamContent(fileStream);
            content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("AccessKey", _accessKey);

            var response = await _httpClient.PutAsync(uploadUrl, content);

            if (!response.IsSuccessStatusCode)
                throw new Exception($"Error al subir archivo a Bunny Storage: {response.StatusCode}");

            return $"{uploadUrl}";
        }
    }
}
