using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Rubro.Repositories;
using Empresa.Infrastructure.Rubro.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Rubro
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRubroInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IRubroRepository, RubroSqlRepository>();
            return services;
        }
    }
}
