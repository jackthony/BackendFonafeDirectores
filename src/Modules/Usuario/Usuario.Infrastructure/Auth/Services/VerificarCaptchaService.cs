/***********
 * Nombre del archivo:  VerificarCaptchaService.cs
 * Descripción:         Servicio encargado de validar el token de reCAPTCHA v2/v3 con los servidores de Google. 
 *                      Utiliza `HttpClient` y la clave secreta configurada para comprobar si el captcha es válido.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial de validación de captcha.
 ***********/

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
