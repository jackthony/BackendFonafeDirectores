/***********
 * Nombre del archivo:  ExportLogsRepository.cs
 * Descripción:         Implementación del repositorio para la exportación de logs del sistema,
 *                      trazabilidad de usuarios y auditoría por roles o estado. Ejecuta procedimientos
 *                      almacenados mediante Dapper.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación de métodos para exportar logs de auditoría, sistema y trazabilidad.
 ***********/

using Dapper;
using System.Data;
using Usuario.Domain.SEG_Log.Parameters;
using Usuario.Domain.SEG_Log.Repositories;
using Usuario.Domain.SEG_Log.Results;

namespace Usuario.Infrastructure.SEG_Log.Persistence.Repositories.SqlServer
{
    public class ExportLogsRepository(IDbConnection connection) : IExportLogsRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<List<AuditLogEstadoUsuarioResult>> ObtenerAuditoriaUsuariosAsync(ObtenerAuditoriaUsuariosRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<AuditLogEstadoUsuarioResult>(
                "AuditarUsuariosHistorico",
                parameters,
                commandType: CommandType.StoredProcedure
            );

            return result.ToList();
        }

        public async Task<List<UsuarioPorTipoUsuarioResult>> ObtenerUsuariosPorTipoUsuarioAsync(ObtenerUsuariosPorTipoUsuarioRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<UsuarioPorTipoUsuarioResult>(
                "ObtenerUsuariosPorTipoUsuario",
                parameters,
                commandType: CommandType.StoredProcedure
            );

            return result.ToList();
        }

        public async Task<List<LogSistemaResult>> ObtenerLogSistemaPorFechasAsync(ObtenerLogSistemaPorFechasRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<LogSistemaResult>(
                "sp_ObtenerLogSistemaPorFechas",
                parameters,
                commandType: CommandType.StoredProcedure
            );

            return result.ToList();
        }

        public async Task<List<LogTrazabilidadResult>> ObtenerLogTrazabilidadAsync(ObtenerLogTrazabilidadRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<LogTrazabilidadResult>(
                "sp_ObtenerLogTrazabilidadPorFechas",
                parameters,
                commandType: CommandType.StoredProcedure
            );

            return result.ToList();
        }
    }
}
