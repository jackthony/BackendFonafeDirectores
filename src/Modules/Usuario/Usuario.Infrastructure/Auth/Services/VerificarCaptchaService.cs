using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Usuario.Application.Auth.Services;

namespace Usuario.Infrastructure.Auth.Services
{
    public class VerificarCaptchaService : ICaptchaService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public VerificarCaptchaService(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
        }
        public async Task<bool> ValidateCaptchaAsync(string captchaResponse)
        {
            var secretKey = _configuration["Captcha:SecretKey"];
            var url = $"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={captchaResponse}";

            var response = await _httpClient.GetStringAsync(url);
            var jsonResponse = JsonSerializer.Deserialize<JsonElement>(response);

            return jsonResponse.GetProperty("success").GetBoolean();
        }
    }
}
