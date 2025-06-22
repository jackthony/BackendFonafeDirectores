using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Director.Repositories;
using Empresa.Infrastructure.Director.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Director
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDirectorInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IDirectorRepository, DirectorSqlRepository>();
            return services;
        }
    }
}
