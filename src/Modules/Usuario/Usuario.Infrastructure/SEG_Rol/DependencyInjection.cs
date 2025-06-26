using Microsoft.Extensions.DependencyInjection;
using Usuario.Domain.Rol.Repositories;
using Usuario.Infrastructure.Rol.Persistence.Repositories.SqlServer;

namespace Usuario.Infrastructure.Rol
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddRolInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IRolRepository, RolSqlRepository>();
            return services;
        }
    }
}
