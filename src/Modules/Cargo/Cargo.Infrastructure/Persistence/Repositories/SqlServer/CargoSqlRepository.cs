using Dapper;
using Cargo.Application.Dtos;
using Cargo.Application.Repositories;
using Cargo.Domain.Models;
using Cargo.Domain.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Cargo.Infrastructure.Persistence.Repositories.SqlServer
{
    public class CargoSqlRepository(IDbConnection connection) : IWriteCargoRepository<SpResultBase>, IReadCargoRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<CargoDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdCargo", id);

            return await _connection.QueryFirstOrDefaultAsync<CargoDto>(
                "sp_ObtenerCargoPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<CargoDto>> ListAsync(ListarCargoRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<CargoDto>(
                "sp_ListarCargo",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<CargoDto>> ListByPaginationAsync(ListarCargoPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarCargoPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<CargoDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<CargoDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearCargoData request)
        {
            var spResult = await ExecAsync<CrearCargoData, SpResultBase>(
            request,
            "sp_RegistrarCargo");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarCargoData request)
        {
            var spResult = await ExecAsync<EliminarCargoData, SpResultBase>(
            request,
            "sp_EliminarCargo");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarCargoData request)
        {
            var spResult = await ExecAsync<ActualizarCargoData, SpResultBase>(
            request,
            "sp_ActualizarCargo");
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
