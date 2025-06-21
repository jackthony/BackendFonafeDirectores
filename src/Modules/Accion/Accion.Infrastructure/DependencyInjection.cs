using Accion.Application.Repositories;
using Accion.Domain.Repositories;
using Accion.Infrastructure.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Accion.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddAccionInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteAccionRepository<SpResultBase>, AccionSqlRepository>();
            services.AddScoped<IReadAccionRepository, AccionSqlRepository>();
            return services;
        }
    }
}
