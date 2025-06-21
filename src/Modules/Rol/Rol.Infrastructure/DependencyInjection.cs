using Rol.Application.Repositories;
using Rol.Domain.Repositories;
using Rol.Infrastructure.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Rol.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRolInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteRolRepository<SpResultBase>, RolSqlRepository>();
            services.AddScoped<IReadRolRepository, RolSqlRepository>();
            return services;
        }
    }
}
