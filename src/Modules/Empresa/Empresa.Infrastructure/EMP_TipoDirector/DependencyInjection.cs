using Empresa.Application.EMP_TipoDirector.Repositories;
using Empresa.Domain.EMP_TipoDirector.Repositories;
using Empresa.Infrastructure.EMP_TipoDirector.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_TipoDirector
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddTipoDirectorInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteTipoDirectorRepository<SpResultBase>, TipoDirectorSqlRepository>();
            services.AddScoped<IReadTipoDirectorRepository, TipoDirectorSqlRepository>();
            return services;
        }
    }
}
