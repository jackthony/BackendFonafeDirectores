using Dapper;
using System.Data;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Repositories;
using Empresa.Domain.Ubigeo.Results;

namespace Empresa.Infrastructure.Ubigeo.Persistence.Repositories.SqlServer
{
    public class UbigeoSqlRepository(IDbConnection connection) : IUbigeoRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<List<DepartamentoResult>> ListDepartamentos(ListarDepartamentoParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<DepartamentoResult>(
                "sp_ListarDepartamento",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<List<DistritoResult>> ListDistritos(ListarDistritoParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<DistritoResult>(
                "sp_ListarDistrito",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<List<ProvinciaResult>> ListProvincias(ListarProvinciaParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<ProvinciaResult>(
                "sp_ListarProvincia",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
    }
}
