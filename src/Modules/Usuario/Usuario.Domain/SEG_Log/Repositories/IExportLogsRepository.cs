/***********
 * Nombre del archivo:  IExportLogsRepository.cs
 * Descripción:         Interfaz que define métodos para la exportación y consulta
 *                      de diferentes tipos de logs, incluyendo auditoría de usuarios,
 *                      usuarios por tipo, logs de sistema y trazabilidad.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial con métodos para obtener logs y auditorías.
 ***********/

using Usuario.Domain.SEG_Log.Parameters;
using Usuario.Domain.SEG_Log.Results;

namespace Usuario.Domain.SEG_Log.Repositories
{
    public interface IExportLogsRepository
    {
        Task<List<AuditLogEstadoUsuarioResult>> ObtenerAuditoriaUsuariosAsync(ObtenerAuditoriaUsuariosRequest request);
        Task<List<UsuarioPorTipoUsuarioResult>> ObtenerUsuariosPorTipoUsuarioAsync(ObtenerUsuariosPorTipoUsuarioRequest request);
        Task<List<LogSistemaResult>> ObtenerLogSistemaPorFechasAsync(ObtenerLogSistemaPorFechasRequest request);
        Task<List<LogTrazabilidadResult>> ObtenerLogTrazabilidadAsync(ObtenerLogTrazabilidadRequest request);
    }
}
