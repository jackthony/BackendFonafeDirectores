using Director.Application.Repositories;
using Director.Domain.Repositories;
using Director.Infrastructure.Persistence.Repositories.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using Shared.Kernel.Responses;

namespace Director.Infrastructure
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
