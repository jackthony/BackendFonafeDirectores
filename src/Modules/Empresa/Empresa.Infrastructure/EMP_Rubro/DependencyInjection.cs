using Empresa.Application.EMP_Rubro.Repositories;
using Empresa.Domain.EMP_Rubro.Repositories;
using Empresa.Infrastructure.EMP_Rubro.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Rubro
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
