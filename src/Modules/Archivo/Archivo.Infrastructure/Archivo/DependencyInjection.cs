using Microsoft.Extensions.DependencyInjection;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Infrastructure.Archivo.Persistence.Repositories.SqlServer;

namespace Archivo.Infrastructure.Archivo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddArchivoInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IArchivoRepository, ArchivoSqlRepository>();
            return services;
        }
    }
}
