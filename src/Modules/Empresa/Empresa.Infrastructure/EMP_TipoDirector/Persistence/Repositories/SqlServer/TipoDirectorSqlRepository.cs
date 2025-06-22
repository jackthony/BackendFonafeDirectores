using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Repositories;
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Infrastructure.TipoDirector.Persistence.Repositories.SqlServer
{
    public class TipoDirectorSqlRepository(IDbConnection connection) : ITipoDirectorRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearTipoDirectorParameters request)
        {
            var spResult = await ExecAsync<CrearTipoDirectorParameters, SpResultBase>(
            request,
            "sp_RegistrarEmpresa");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarTipoDirectorParameters request)
        {
            var spResult = await ExecAsync<EliminarTipoDirectorParameters, SpResultBase>(
            request,
            "sp_EliminarEmpresa");
            return spResult;
        }

        public async Task<TipoDirectorResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdEmpresa", id);

            return await _connection.QueryFirstOrDefaultAsync<TipoDirectorResult>(
                "sp_ObtenerEmpresaPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<TipoDirectorResult>> ListAsync(ListarTipoDirectorParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<TipoDirectorResult>(
                "sp_ListarEmpresa",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<TipoDirectorResult>> ListByPaginationAsync(ListarTipoDirectorPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarEmpresaPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<TipoDirectorResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<TipoDirectorResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarTipoDirectorParameters request)
        {
            var spResult = await ExecAsync<ActualizarTipoDirectorParameters, SpResultBase>(
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
