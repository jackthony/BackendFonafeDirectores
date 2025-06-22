using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Repositories;
using Empresa.Domain.Director.Results;

namespace Empresa.Infrastructure.Director.Persistence.Repositories.SqlServer
{
    public class DirectorSqlRepository(IDbConnection connection) : IDirectorRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearDirectorParameters request)
        {
            var spResult = await ExecAsync<CrearDirectorParameters, SpResultBase>(
            request,
            "sp_RegistrarEmpresa");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarDirectorParameters request)
        {
            var spResult = await ExecAsync<EliminarDirectorParameters, SpResultBase>(
            request,
            "sp_EliminarEmpresa");
            return spResult;
        }

        public async Task<DirectorResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdEmpresa", id);

            return await _connection.QueryFirstOrDefaultAsync<DirectorResult>(
                "sp_ObtenerEmpresaPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<DirectorResult>> ListAsync(ListarDirectorParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<DirectorResult>(
                "sp_ListarEmpresa",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<DirectorResult>> ListByPaginationAsync(ListarDirectorPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarEmpresaPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<DirectorResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<DirectorResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarDirectorParameters request)
        {
            var spResult = await ExecAsync<ActualizarDirectorParameters, SpResultBase>(
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
