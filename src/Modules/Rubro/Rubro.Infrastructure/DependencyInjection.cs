using Rubro.Application.Repositories;
using Rubro.Domain.Repositories;
using Rubro.Infrastructure.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Rubro.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRubroInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteRubroRepository<SpResultBase>, RubroSqlRepository>();
            services.AddScoped<IReadRubroRepository, RubroSqlRepository>();
            return services;
        }
    }
}
