using Empresa.Application.EMP_Especialidad.Repositories;
using Empresa.Domain.EMP_Especialidad.Repositories;
using Empresa.Infrastructure.EMP_Especialidad.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Especialidad
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
