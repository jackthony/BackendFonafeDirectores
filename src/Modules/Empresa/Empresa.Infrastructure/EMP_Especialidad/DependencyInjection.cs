using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Especialidad.Repositories;
using Empresa.Infrastructure.Especialidad.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Especialidad
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEspecialidadInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IEspecialidadRepository, EspecialidadSqlRepository>();
            return services;
        }
    }
}
