using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Repositories;
using Empresa.Domain.Rubro.Results;

namespace Empresa.Infrastructure.Rubro.Persistence.Repositories.SqlServer
{
    public class RubroSqlRepository(IDbConnection connection) : IRubroRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearRubroParameters request)
        {
            var spResult = await ExecAsync<CrearRubroParameters, SpResultBase>(
            request,
            "sp_RegistrarEmpresa");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarRubroParameters request)
        {
            var spResult = await ExecAsync<EliminarRubroParameters, SpResultBase>(
            request,
            "sp_EliminarEmpresa");
            return spResult;
        }

        public async Task<RubroResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdEmpresa", id);

            return await _connection.QueryFirstOrDefaultAsync<RubroResult>(
                "sp_ObtenerEmpresaPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<RubroResult>> ListAsync(ListarRubroParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<RubroResult>(
                "sp_ListarEmpresa",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<RubroResult>> ListByPaginationAsync(ListarRubroPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarEmpresaPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<RubroResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<RubroResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarRubroParameters request)
        {
            var spResult = await ExecAsync<ActualizarRubroParameters, SpResultBase>(
            request,
            "sp_ActualizarEmpresa");
            return spResult;
        }

        protected async Task<TResponse> ExecAsync<TRequest, TResponse>(TRequest request, string storedProcedure)
        {
            var parameters = new DynamicParameters(request);

            return await _connection.QueryFirstAsync<TResponse>(
                storedProcedure,
                parameters,
                commandType: CommandType.StoredProcedure);
        }
    }
}
