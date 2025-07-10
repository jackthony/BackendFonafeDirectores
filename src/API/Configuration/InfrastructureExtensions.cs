/***********
 * Nombre del archivo:  InfrastructureExtensions.cs
 * Descripción:         Extensiones para configurar infraestructura común de la aplicación.
 *                      
 *                      - AddDatabase: Configura la conexión a la base de datos SQL Server 
 *                        usando la cadena de conexión definida en ServiceSettings.
 *                      
 *                      - AddStorage: Configura opciones de almacenamiento usando 
 *                        la configuración definida en un archivo JSON externo (bunny.settings.json).
 *                        
 *                      Estas extensiones facilitan la inyección de dependencias y centralizan 
 *                      la configuración de recursos comunes.
 *                      
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial de configuraciones de base de datos y almacenamiento.
 ***********/

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
