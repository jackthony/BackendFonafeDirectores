using Microsoft.Extensions.DependencyInjection;
using Empresa.Domain.Ubigeo.Repositories;
using Empresa.Infrastructure.Ubigeo.Persistence.Repositories.SqlServer;

namespace Empresa.Infrastructure.Ubigeo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddUbigeoInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUbigeoRepository, UbigeoSqlRepository>();
            return services;
        }
    }
}
