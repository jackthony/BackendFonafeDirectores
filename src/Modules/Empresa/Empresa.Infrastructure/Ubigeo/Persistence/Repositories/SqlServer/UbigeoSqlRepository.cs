using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.Ubigeo.Parameters;
using Empresa.Domain.Ubigeo.Repositories;
using Empresa.Domain.Ubigeo.Results;

namespace Empresa.Infrastructure.Ubigeo.Persistence.Repositories.SqlServer
{
    public class UbigeoSqlRepository(IDbConnection connection) : IUbigeoRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearUbigeoParameters request)
        {
            var spResult = await ExecAsync<CrearUbigeoParameters, SpResultBase>(
            request,
            "sp_RegistrarUbigeo");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarUbigeoParameters request)
        {
            var spResult = await ExecAsync<EliminarUbigeoParameters, SpResultBase>(
            request,
            "sp_EliminarUbigeo");
            return spResult;
        }

        public async Task<UbigeoResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdUbigeo", id);

            return await _connection.QueryFirstOrDefaultAsync<UbigeoResult>(
                "sp_ObtenerUbigeoPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<UbigeoResult>> ListAsync(ListarUbigeoParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<UbigeoResult>(
                "sp_ListarUbigeo",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<UbigeoResult>> ListByPaginationAsync(ListarUbigeoPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarUbigeoPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<UbigeoResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<UbigeoResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarUbigeoParameters request)
        {
            var spResult = await ExecAsync<ActualizarUbigeoParameters, SpResultBase>(
            request,
            "sp_ActualizarUbigeo");
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
