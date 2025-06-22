using Empresa.Application.EMP_Empresa.Repositories;
using Empresa.Domain.EMP_Empresa.Repositories;
using Empresa.Infrastructure.EMP_Empresa.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Empresa
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddEmpresaInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteEmpresaRepository<SpResultBase>, EmpresaSqlRepository>();
            services.AddScoped<IReadEmpresaRepository, EmpresaSqlRepository>();
            return services;
        }
    }
}
