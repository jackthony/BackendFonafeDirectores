using Cargo.Application.Repositories;
using Cargo.Domain.Repositories;
using Cargo.Infrastructure.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Cargo.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddCargoInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteCargoRepository<SpResultBase>, CargoSqlRepository>();
            services.AddScoped<IReadCargoRepository, CargoSqlRepository>();
            return services;
        }
    }
}
