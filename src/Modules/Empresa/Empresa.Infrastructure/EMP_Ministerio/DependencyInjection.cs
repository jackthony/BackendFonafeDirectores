using Empresa.Application.EMP_Ministerio.Repositories;
using Empresa.Domain.EMP_Ministerio.Repositories;
using Empresa.Infrastructure.EMP_Ministerio.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Empresa.Infrastructure.EMP_Ministerio
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddMinisterioInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteMinisterioRepository<SpResultBase>, MinisterioSqlRepository>();
            services.AddScoped<IReadMinisterioRepository, MinisterioSqlRepository>();
            return services;
        }
    }
}
