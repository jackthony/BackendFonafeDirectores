using Dapper;
using Empresa.Domain.Dieta.Parameters;
using Empresa.Domain.Dieta.Repositories;
using Empresa.Domain.Dieta.Results;
using System.Data;

namespace Empresa.Infrastructure.Dieta.Persistence.Repositories.SqlServer
{
    public class DietaSqlRepository(IDbConnection connection) : IDietaRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<DietaResult?> ObtenerDietaAsync(ObtenerDietaParameter request)
        {
            var parameters = new DynamicParameters(request);

            return await _connection.QueryFirstOrDefaultAsync<DietaResult>(
                "sp_ObtenerDieta",
                parameters,
                commandType: CommandType.StoredProcedure);
        }
    }
}
