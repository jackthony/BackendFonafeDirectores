using TipoDirector.Application.Repositories;
using TipoDirector.Domain.Repositories;
using TipoDirector.Infrastructure.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace TipoDirector.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddTipoDirectorInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteTipoDirectorRepository<SpResultBase>, TipoDirectorSqlRepository>();
            services.AddScoped<IReadTipoDirectorRepository, TipoDirectorSqlRepository>();
            return services;
        }
    }
}
