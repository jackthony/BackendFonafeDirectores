using Dapper;
using Rol.Application.Dtos;
using Rol.Application.Repositories;
using Rol.Domain.Models;
using Rol.Domain.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Rol.Infrastructure.Persistence.Repositories.SqlServer
{
    public class RolSqlRepository(IDbConnection connection) : IWriteRolRepository<SpResultBase>, IReadRolRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<RolDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdRol", id);

            return await _connection.QueryFirstOrDefaultAsync<RolDto>(
                "sp_ObtenerRolPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<RolDto>> ListAsync(ListarRolRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<RolDto>(
                "sp_ListarRol",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<RolDto>> ListByPaginationAsync(ListarRolPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarRolPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<RolDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<RolDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearRolData request)
        {
            var spResult = await ExecAsync<CrearRolData, SpResultBase>(
            request,
            "sp_RegistrarRol");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarRolData request)
        {
            var spResult = await ExecAsync<EliminarRolData, SpResultBase>(
            request,
            "sp_EliminarRol");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarRolData request)
        {
            var spResult = await ExecAsync<ActualizarRolData, SpResultBase>(
            request,
            "sp_ActualizarRol");
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
