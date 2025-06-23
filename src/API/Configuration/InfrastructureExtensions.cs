using Api.Settings;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace Api.Common
{
    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<ServiceSettings>(configuration.GetSection("ServiceSettings"));

            services.AddScoped<IDbConnection>(sp =>
            {
                var settings = sp.GetRequiredService<IOptions<ServiceSettings>>().Value;
                return new SqlConnection(settings.ConnectionString);
            });

            return services;
        }

        public static IServiceCollection AddStorage(this IServiceCollection services)
        {
            var bunnyConfig = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("bunny.settings.json", optional: false, reloadOnChange: true)
                .Build();

            services.Configure<BunnyStorageOptions>(bunnyConfig);

            return services;
        }
    }
}
