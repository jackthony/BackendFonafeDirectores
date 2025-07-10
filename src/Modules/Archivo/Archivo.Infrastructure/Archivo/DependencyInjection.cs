/*****
 * Nombre del archivo:  DependencyInjections.cs
 * Descripción:         Clase estática que configura la inyección de dependencias para los componentes de la infraestructura de archivos. 
 *                      Registra los repositorios y servicios necesarios para la gestión de archivos, como el almacenamiento, la exportación, la importación y la validación de referencias.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Microsoft.Extensions.DependencyInjection;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Infrastructure.Archivo.Persistence.Repositories.SqlServer;
using Archivo.Application.Archivo.Services;
using Archivo.Infrastructure.Archivo.Services;

namespace Archivo.Infrastructure.Archivo
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddArchivoInfrastructure(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped<IArchivoRepository, ArchivoSqlRepository>();
            services.AddScoped<IExportImportRepository, ExportImportSqlRepository>();
            services.AddScoped<IReferenciaRepository, ReferenciaRepository>();

            // Services
            services.AddScoped<IStorageService, BunnyStorageService>();
            services.AddScoped<IExportImportService, ExportImportService>();
            services.AddScoped<IValidarReferenciaService, ValidarReferenciaService>();
            return services;
        }
    }
}
