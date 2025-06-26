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
            return services;
        }
    }
}
