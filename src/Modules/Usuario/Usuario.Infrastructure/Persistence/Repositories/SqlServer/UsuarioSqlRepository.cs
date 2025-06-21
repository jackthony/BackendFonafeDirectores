using Dapper;
using Usuario.Application.Dtos;
using Usuario.Application.Repositories;
using Usuario.Domain.Models;
using Usuario.Domain.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Usuario.Infrastructure.Persistence.Repositories.SqlServer
{
    public class UsuarioSqlRepository(IDbConnection connection) : IWriteUsuarioRepository<SpResultBase>, IReadUsuarioRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<UsuarioDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdUsuario", id);

            return await _connection.QueryFirstOrDefaultAsync<UsuarioDto>(
                "sp_ObtenerUsuarioPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<UsuarioDto>> ListAsync(ListarUsuarioRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<UsuarioDto>(
                "sp_ListarUsuario",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<UsuarioDto>> ListByPaginationAsync(ListarUsuarioPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarUsuarioPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<UsuarioDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<UsuarioDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearUsuarioData request)
        {
            var spResult = await ExecAsync<CrearUsuarioData, SpResultBase>(
            request,
            "sp_RegistrarUsuario");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarUsuarioData request)
        {
            var spResult = await ExecAsync<EliminarUsuarioData, SpResultBase>(
            request,
            "sp_EliminarUsuario");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarUsuarioData request)
        {
            var spResult = await ExecAsync<ActualizarUsuarioData, SpResultBase>(
            request,
            "sp_ActualizarUsuario");
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
