using Especialidad.Application.Repositories;
using Especialidad.Domain.Repositories;
using Especialidad.Infrastructure.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Especialidad.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEspecialidadInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteEspecialidadRepository<SpResultBase>, EspecialidadSqlRepository>();
            services.AddScoped<IReadEspecialidadRepository, EspecialidadSqlRepository>();
            return services;
        }
    }
}
