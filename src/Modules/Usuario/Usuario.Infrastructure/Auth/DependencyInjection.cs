/***********
 * Nombre del archivo:  DependencyInjection.cs
 * Descripción:         Clase de configuración de dependencias para el módulo de autenticación. 
 *                      Registra servicios como hashing de contraseñas, generación de tokens JWT,
 *                      verificación de captcha, envío de correos y repositorio de autenticación.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Registro de servicios de autenticación e infraestructura asociada.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Repositories;
using Usuario.Infrastructure.Auth.Persistence.Repositories.SqlServer;
using Usuario.Infrastructure.Auth.Services;

namespace Usuario.Infrastructure.Auth
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAuthInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IPasswordHasher, PasswordHasherBCrypt>();
            services.AddScoped<ITokenService, JwtTokenService>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<ICaptchaService, VerificarCaptchaService>();
            services.AddScoped<IEmailService, EmailService>();
            return services;
        }
    }
}
