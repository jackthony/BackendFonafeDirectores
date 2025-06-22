using Empresa.Application.EMP_Cargo.Repositories;
using Empresa.Domain.EMP_Cargo.Repositories;
using Empresa.Infrastructure.EMP_Cargo.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Cargo
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
