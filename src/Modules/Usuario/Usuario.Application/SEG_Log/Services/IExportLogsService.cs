using Usuario.Domain.SEG_Log.Results;

namespace Usuario.Application.SEG_Log.Services
{
    public interface IExportLogsService
    {
        Stream ExportarAuditoriaUsuariosExcel(List<AuditLogEstadoUsuarioResult> usuarios);
        Stream ExportarUsuariosPorTipoUsuarioExcel(List<UsuarioPorTipoUsuarioResult> usuarios);
        Stream ExportarLogSistemaExcel(List<LogSistemaResult> logs);
        Stream ExportarLogTrazabilidadExcel(List<LogTrazabilidadResult> logs);
    }
}
