using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Cargo.Repositories;
using Empresa.Infrastructure.Cargo.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Cargo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddCargoInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ICargoRepository, CargoSqlRepository>();
            return services;
        }
    }
}
