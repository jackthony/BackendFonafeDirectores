using Microsoft.Extensions.DependencyInjection;
using Usuario.Domain.User.Repositories;
using Usuario.Infrastructure.User.Persistence.Repositories.SqlServer;

namespace Usuario.Infrastructure.User
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddUserInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserSqlRepository>();
            return services;
        }
    }
}
