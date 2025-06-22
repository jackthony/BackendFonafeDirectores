using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.Cargo.Parameters;
using Empresa.Domain.Cargo.Repositories;
using Empresa.Domain.Cargo.Results;

namespace Empresa.Infrastructure.Cargo.Persistence.Repositories.SqlServer
{
    public class CargoSqlRepository(IDbConnection connection) : ICargoRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearCargoParameters request)
        {
            var spResult = await ExecAsync<CrearCargoParameters, SpResultBase>(
            request,
            "sp_RegistrarEmpresa");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarCargoParameters request)
        {
            var spResult = await ExecAsync<EliminarCargoParameters, SpResultBase>(
            request,
            "sp_EliminarEmpresa");
            return spResult;
        }

        public async Task<CargoResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdEmpresa", id);

            return await _connection.QueryFirstOrDefaultAsync<CargoResult>(
                "sp_ObtenerEmpresaPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<CargoResult>> ListAsync(ListarCargoParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<CargoResult>(
                "sp_ListarEmpresa",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<CargoResult>> ListByPaginationAsync(ListarCargoPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarEmpresaPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<CargoResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<CargoResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarCargoParameters request)
        {
            var spResult = await ExecAsync<ActualizarCargoParameters, SpResultBase>(
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
