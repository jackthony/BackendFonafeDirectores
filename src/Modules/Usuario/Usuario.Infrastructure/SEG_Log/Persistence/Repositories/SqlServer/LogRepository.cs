using Dapper;
using System.Data;
using Usuario.Domain.SEG_Log.Parameters;
using Usuario.Domain.SEG_Log.Repositories;

namespace Usuario.Infrastructure.SEG_Log.Persistence.Repositories.SqlServer
{
    public class LogRepository(IDbConnection connection) : ILogRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task RegistrarAuditoriaAsync(LogAuditoriaParameters parameters)
        {
            var query = "sp_RegistrarAuditoria";
            await _connection.ExecuteAsync(query, parameters, commandType: CommandType.StoredProcedure);
        }

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
