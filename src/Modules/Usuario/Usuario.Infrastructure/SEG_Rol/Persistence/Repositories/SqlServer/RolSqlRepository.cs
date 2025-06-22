using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Usuario.Domain.Rol.Parameters;
using Usuario.Domain.Rol.Repositories;
using Usuario.Domain.Rol.Results;

namespace Usuario.Infrastructure.Rol.Persistence.Repositories.SqlServer
{
    public class RolSqlRepository(IDbConnection connection) : IRolRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearRolParameters request)
        {
            var spResult = await ExecAsync<CrearRolParameters, SpResultBase>(
            request,
            "sp_RegistrarRol");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarRolParameters request)
        {
            var spResult = await ExecAsync<EliminarRolParameters, SpResultBase>(
            request,
            "sp_EliminarRol");
            return spResult;
        }

        public async Task<RolResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdRol", id);

            return await _connection.QueryFirstOrDefaultAsync<RolResult>(
                "sp_ObtenerRolPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<RolResult>> ListAsync(ListarRolParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<RolResult>(
                "sp_ListarRol",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<RolResult>> ListByPaginationAsync(ListarRolPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarRolPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<RolResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<RolResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarRolParameters request)
        {
            var spResult = await ExecAsync<ActualizarRolParameters, SpResultBase>(
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
