using Dapper;
using Modulo.Application.Dtos;
using Modulo.Application.Repositories;
using Modulo.Domain.Models;
using Modulo.Domain.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Modulo.Infrastructure.Persistence.Repositories.SqlServer
{
    public class ModuloSqlRepository(IDbConnection connection) : IWriteModuloRepository<SpResultBase>, IReadModuloRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<ModuloDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdModulo", id);

            return await _connection.QueryFirstOrDefaultAsync<ModuloDto>(
                "sp_ObtenerModuloPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<ModuloDto>> ListAsync(ListarModuloRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<ModuloDto>(
                "sp_ListarModulo",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<ModuloDto>> ListByPaginationAsync(ListarModuloPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarModuloPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<ModuloDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<ModuloDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearModuloData request)
        {
            var spResult = await ExecAsync<CrearModuloData, SpResultBase>(
            request,
            "sp_RegistrarModulo");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarModuloData request)
        {
            var spResult = await ExecAsync<EliminarModuloData, SpResultBase>(
            request,
            "sp_EliminarModulo");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarModuloData request)
        {
            var spResult = await ExecAsync<ActualizarModuloData, SpResultBase>(
            request,
            "sp_ActualizarModulo");
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
