/***********
* Nombre del archivo: IExportLogsService.cs
* Descripción:        **Define la interfaz para los servicios de exportación de logs** a formatos de archivo.
*                     Proporciona métodos para generar flujos de datos (streams) en formato Excel
*                     a partir de diversas listas de resultados de logs, incluyendo auditoría de usuarios,
*                     usuarios por tipo, logs del sistema y logs de trazabilidad. Esto permite
*                     la descarga o el procesamiento posterior de los datos exportados.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la interfaz IExportLogsService.
***********/

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
