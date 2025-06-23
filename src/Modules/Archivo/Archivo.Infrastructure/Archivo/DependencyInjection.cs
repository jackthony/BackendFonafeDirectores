using Microsoft.Extensions.DependencyInjection;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Infrastructure.Archivo.Persistence.Repositories.SqlServer;
using Archivo.Application.Archivo.Services;
using Archivo.Infrastructure.Archivo.Services;

namespace Archivo.Infrastructure.Archivo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddArchivoInfrastructure(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped<IArchivoRepository, ArchivoSqlRepository>();

            // Services
            services.AddScoped<IStorageService, BunnyStorageService>();
            return services;
        }
    }
}
