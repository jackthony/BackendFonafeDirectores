using Ministerio.Application.Repositories;
using Ministerio.Domain.Repositories;
using Ministerio.Infrastructure.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Ministerio.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddMinisterioInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteMinisterioRepository<SpResultBase>, MinisterioSqlRepository>();
            services.AddScoped<IReadMinisterioRepository, MinisterioSqlRepository>();
            return services;
        }
    }
}
