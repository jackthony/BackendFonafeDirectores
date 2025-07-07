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
                "AuditarUsuarios",
                parameters,
                commandType: CommandType.StoredProcedure
            );

            return result.ToList();
        }
    }
}
