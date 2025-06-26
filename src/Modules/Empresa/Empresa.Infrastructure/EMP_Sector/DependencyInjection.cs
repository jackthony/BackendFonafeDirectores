using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Sector.Repositories;
using Empresa.Infrastructure.Sector.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Sector
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddSectorInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ISectorRepository, SectorSqlRepository>();
            return services;
        }
    }
}
