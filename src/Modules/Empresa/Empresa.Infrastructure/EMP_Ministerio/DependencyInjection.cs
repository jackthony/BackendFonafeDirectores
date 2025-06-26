using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Ministerio.Repositories;
using Empresa.Infrastructure.Ministerio.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Ministerio
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddMinisterioInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IMinisterioRepository, MinisterioSqlRepository>();
            return services;
        }
    }
}
