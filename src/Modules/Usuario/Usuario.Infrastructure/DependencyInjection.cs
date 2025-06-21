using Usuario.Application.Repositories;
using Usuario.Domain.Repositories;
using Usuario.Infrastructure.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Usuario.Infrastructure
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddUsuarioInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IWriteUsuarioRepository<SpResultBase>, UsuarioSqlRepository>();
            services.AddScoped<IReadUsuarioRepository, UsuarioSqlRepository>();
            return services;
        }
    }
}
