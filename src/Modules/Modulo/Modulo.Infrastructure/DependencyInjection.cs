using Modulo.Application.Repositories;
using Modulo.Domain.Repositories;
using Modulo.Infrastructure.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Modulo.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddModuloInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteModuloRepository<SpResultBase>, ModuloSqlRepository>();
            services.AddScoped<IReadModuloRepository, ModuloSqlRepository>();
            return services;
        }
    }
}
