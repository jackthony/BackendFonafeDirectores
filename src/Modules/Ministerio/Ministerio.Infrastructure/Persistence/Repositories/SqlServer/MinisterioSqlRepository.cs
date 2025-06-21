using Dapper;
using Ministerio.Application.Dtos;
using Ministerio.Application.Repositories;
using Ministerio.Domain.Models;
using Ministerio.Domain.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Ministerio.Infrastructure.Persistence.Repositories.SqlServer
{
    public class MinisterioSqlRepository(IDbConnection connection) : IWriteMinisterioRepository<SpResultBase>, IReadMinisterioRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<MinisterioDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdMinisterio", id);

            return await _connection.QueryFirstOrDefaultAsync<MinisterioDto>(
                "sp_ObtenerMinisterioPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<MinisterioDto>> ListAsync(ListarMinisterioRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<MinisterioDto>(
                "sp_ListarMinisterio",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<MinisterioDto>> ListByPaginationAsync(ListarMinisterioPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarMinisterioPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<MinisterioDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<MinisterioDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearMinisterioData request)
        {
            var spResult = await ExecAsync<CrearMinisterioData, SpResultBase>(
            request,
            "sp_RegistrarMinisterio");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarMinisterioData request)
        {
            var spResult = await ExecAsync<EliminarMinisterioData, SpResultBase>(
            request,
            "sp_EliminarMinisterio");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarMinisterioData request)
        {
            var spResult = await ExecAsync<ActualizarMinisterioData, SpResultBase>(
            request,
            "sp_ActualizarMinisterio");
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
