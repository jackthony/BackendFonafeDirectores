using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Dieta.Repositories;
using Empresa.Infrastructure.Dieta.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Dieta
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDietaInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IDietaRepository, DietaSqlRepository>();
            return services;
        }
    }
}
