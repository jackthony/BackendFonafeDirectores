using Sector.Application.Repositories;
using Sector.Domain.Repositories;
using Sector.Infrastructure.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Sector.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddSectorInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteSectorRepository<SpResultBase>, SectorSqlRepository>();
            services.AddScoped<IReadSectorRepository, SectorSqlRepository>();
            return services;
        }
    }
}
