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
