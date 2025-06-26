using Microsoft.Extensions.DependencyInjection;
using Usuario.Domain.PermisoRol.Repositories;
using Usuario.Infrastructure.PermisoRol.Persistence.Repositories.SqlServer;

namespace Usuario.Infrastructure.PermisoRol
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddPermisoRolInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IPermisoRolRepository, PermisoRolSqlRepository>();
            return services;
        }
    }
}
