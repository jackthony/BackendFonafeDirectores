using Empresa.Application.EMP_Director.Repositories;
using Empresa.Domain.EMP_Director.Repositories;
using Empresa.Infrastructure.EMP_Director.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Director
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDirectorInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteDirectorRepository<SpResultBase>, DirectorSqlRepository>();
            services.AddScoped<IReadDirectorRepository, DirectorSqlRepository>();
            return services;
        }
    }
}
