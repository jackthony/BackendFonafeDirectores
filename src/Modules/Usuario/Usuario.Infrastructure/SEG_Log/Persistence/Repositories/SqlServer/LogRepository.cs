/***********
 * Nombre del archivo:  LogRepository.cs
 * Descripción:         Implementación del repositorio de logs que interactúa con la base de datos
 *                      para registrar eventos del sistema y trazabilidad utilizando procedimientos almacenados.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación de métodos para registrar logs de sistema y trazabilidad mediante Dapper.
 ***********/

using Dapper;
using System.Data;
using Usuario.Domain.SEG_Log.Parameters;
using Usuario.Domain.SEG_Log.Repositories;

namespace Usuario.Infrastructure.SEG_Log.Persistence.Repositories.SqlServer
{
    public class LogRepository(IDbConnection connection) : ILogRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task RegistrarSistemaAsync(LogSistemaParameters parameters)
        {
            var query = "sp_RegistrarLogSistema";

            await _connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);
        }

        public async Task RegistrarTrazabilidadAsync(LogTrazabilidadParameters parameters)
        {
            var query = "sp_RegistrarTrazabilidad";

            await _connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}
