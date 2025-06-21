using Dapper;
using Accion.Application.Dtos;
using Accion.Application.Repositories;
using Accion.Domain.Models;
using Accion.Domain.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Accion.Infrastructure.Persistence.Repositories.SqlServer
{
    public class AccionSqlRepository(IDbConnection connection) : IWriteAccionRepository<SpResultBase>, IReadAccionRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<AccionDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdAccion", id);

            return await _connection.QueryFirstOrDefaultAsync<AccionDto>(
                "sp_ObtenerAccionPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<AccionDto>> ListAsync(ListarAccionRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<AccionDto>(
                "sp_ListarAccion",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<AccionDto>> ListByPaginationAsync(ListarAccionPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarAccionPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<AccionDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<AccionDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearAccionData request)
        {
            var spResult = await ExecAsync<CrearAccionData, SpResultBase>(
            request,
            "sp_RegistrarAccion");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarAccionData request)
        {
            var spResult = await ExecAsync<EliminarAccionData, SpResultBase>(
            request,
            "sp_EliminarAccion");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarAccionData request)
        {
            var spResult = await ExecAsync<ActualizarAccionData, SpResultBase>(
            request,
            "sp_ActualizarAccion");
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
