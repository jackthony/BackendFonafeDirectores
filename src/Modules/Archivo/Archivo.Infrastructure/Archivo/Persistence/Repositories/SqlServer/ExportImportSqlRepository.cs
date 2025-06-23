using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Domain.Archivo.Results;
using Dapper;
using System.Data;

namespace Archivo.Infrastructure.Archivo.Persistence.Repositories.SqlServer
{
    public class ExportImportSqlRepository(IDbConnection connection) : IExportImportRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<List<DirectorDocResult>> GetDirectores(ExportParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<DirectorDocResult>(
                "sp_ListarDirectorDoc",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<List<EmpresaDocResult>> GetEmpresas(ExportParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<EmpresaDocResult>(
                "sp_ListarEmpresaDoc",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
