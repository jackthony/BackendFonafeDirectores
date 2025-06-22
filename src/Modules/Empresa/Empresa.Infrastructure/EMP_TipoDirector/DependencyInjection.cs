using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.TipoDirector.Repositories;
using Empresa.Infrastructure.TipoDirector.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.TipoDirector
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddTipoDirectorInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ITipoDirectorRepository, TipoDirectorSqlRepository>();
            return services;
        }
    }
}
