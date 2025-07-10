/***********
 * Nombre del archivo:  DependencyInjection.cs
 * Descripción:         Clase estática encargada de registrar las dependencias del módulo de logs,
 *                      incluyendo servicios e implementaciones de repositorios relacionados a
 *                      auditoría, trazabilidad y exportación de logs.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Registro de LogService, LogRepository, TrazabilidadInspector,
 *                      ExportLogsRepository e ExportLogsService.
 ***********/

using Microsoft.Extensions.DependencyInjection;
using Usuario.Application.SEG_Log.Services;
using Usuario.Domain.SEG_Log.Repositories;
using Usuario.Infrastructure.SEG_Log.Persistence.Repositories.SqlServer;
using Usuario.Infrastructure.SEG_Log.Services;

namespace Usuario.Infrastructure.SEG_Log
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddLogInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ILogService, LogService>();
            services.AddScoped<ILogRepository, LogRepository>();
            services.AddScoped<ITrazabilidadInspector, TrazabilidadInspector>();
            services.AddScoped<IExportLogsRepository, ExportLogsRepository>();
            
            services.AddScoped<IExportLogsService, ExportLogsService>();

            return services;
        }
    }
}
