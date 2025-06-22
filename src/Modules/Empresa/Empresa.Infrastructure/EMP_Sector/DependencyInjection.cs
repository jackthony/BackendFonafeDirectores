using Empresa.Application.EMP_Sector.Repositories;
using Empresa.Domain.EMP_Sector.Repositories;
using Empresa.Infrastructure.EMP_Sector.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Sector
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
