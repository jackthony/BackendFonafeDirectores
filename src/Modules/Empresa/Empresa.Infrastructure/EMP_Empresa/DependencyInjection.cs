using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Empresa.Repositories;
using Empresa.Infrastructure.Empresa.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Empresa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEmpresaInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IEmpresaRepository, EmpresaSqlRepository>();
            return services;
        }
    }
}
