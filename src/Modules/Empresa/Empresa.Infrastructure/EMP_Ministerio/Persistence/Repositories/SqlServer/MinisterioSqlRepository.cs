using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.Ministerio.Parameters;
using Empresa.Domain.Ministerio.Repositories;
using Empresa.Domain.Ministerio.Results;

namespace Empresa.Infrastructure.Ministerio.Persistence.Repositories.SqlServer
{
    public class MinisterioSqlRepository(IDbConnection connection) : IMinisterioRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearMinisterioParameters request)
        {
            var spResult = await ExecAsync<CrearMinisterioParameters, SpResultBase>(
            request,
            "sp_RegistrarEmpresa");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarMinisterioParameters request)
        {
            var spResult = await ExecAsync<EliminarMinisterioParameters, SpResultBase>(
            request,
            "sp_EliminarEmpresa");
            return spResult;
        }

        public async Task<MinisterioResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdEmpresa", id);

            return await _connection.QueryFirstOrDefaultAsync<MinisterioResult>(
                "sp_ObtenerEmpresaPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<MinisterioResult>> ListAsync(ListarMinisterioParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<MinisterioResult>(
                "sp_ListarEmpresa",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<MinisterioResult>> ListByPaginationAsync(ListarMinisterioPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarEmpresaPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<MinisterioResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<MinisterioResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarMinisterioParameters request)
        {
            var spResult = await ExecAsync<ActualizarMinisterioParameters, SpResultBase>(
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
