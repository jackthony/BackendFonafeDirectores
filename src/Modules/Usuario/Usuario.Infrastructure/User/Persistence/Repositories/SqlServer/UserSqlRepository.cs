/***********
 * Nombre del archivo:  UserSqlRepository.cs
 * Descripción:         Implementación del repositorio de usuarios para SQL Server utilizando Dapper.
 *                      Proporciona operaciones CRUD y consultas paginadas a través de stored procedures.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación completa de operaciones: crear, actualizar, eliminar, listar y obtener por ID.
 ***********/

using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Usuario.Domain.User.Parameters;
using Usuario.Domain.User.Repositories;
using Usuario.Domain.User.Results;

namespace Usuario.Infrastructure.User.Persistence.Repositories.SqlServer
{
    public class UserSqlRepository(IDbConnection connection) : IUserRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearUserParameters request)
        {
            var spResult = await ExecAsync<CrearUserParameters, SpResultBase>(
            request,
            "sp_RegistrarUsuario");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarUserParameters request)
        {
            var spResult = await ExecAsync<EliminarUserParameters, SpResultBase>(
            request,
            "sp_EliminarUsuario");
            return spResult;
        }

        public async Task<UserResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdUsuario", id);

            return await _connection.QueryFirstOrDefaultAsync<UserResult>(
                "sp_ObtenerUsuarioPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<UserResult>> ListAsync(ListarUserParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<UserResult>(
                "sp_ListarUsuario",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<UserResult>> ListByPaginationAsync(ListarUserPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarUsuarioPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<UserResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<UserResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarUserParameters request)
        {
            var spResult = await ExecAsync<ActualizarUserParameters, SpResultBase>(
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
