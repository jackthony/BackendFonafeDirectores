using Microsoft.Extensions.DependencyInjection;
using Usuario.Domain.Modulo.Repositories;
using Usuario.Infrastructure.Modulo.Persistence.Repositories.SqlServer;

namespace Usuario.Infrastructure.Modulo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddModuloInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IModuloRepository, ModuloSqlRepository>();
            return services;
        }
    }
}
