/***********
 * Nombre del archivo:  PermisoRolSqlRepository.cs
 * Descripción:         Implementación del repositorio para la gestión de permisos por rol. 
 *                      Incluye operaciones CRUD y consultas paginadas usando procedimientos almacenados y Dapper.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación completa del repositorio SQL para PermisoRol.
 ***********/

using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Usuario.Domain.PermisoRol.Parameters;
using Usuario.Domain.PermisoRol.Repositories;
using Usuario.Domain.PermisoRol.Results;

namespace Usuario.Infrastructure.PermisoRol.Persistence.Repositories.SqlServer
{
    public class PermisoRolSqlRepository(IDbConnection connection) : IPermisoRolRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearPermisoRolParameters request)
        {
            var spResult = await ExecAsync<CrearPermisoRolParameters, SpResultBase>(
            request,
            "sp_RegistrarPermisoRol");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarPermisoRolParameters request)
        {
            var spResult = await ExecAsync<EliminarPermisoRolParameters, SpResultBase>(
            request,
            "sp_EliminarPermisoRol");
            return spResult;
        }

        public async Task<PermisoRolResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdPermisoRol", id);

            return await _connection.QueryFirstOrDefaultAsync<PermisoRolResult>(
                "sp_ObtenerPermisoRolPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<PermisoRolResult>> ListAsync(ListarPermisoRolParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<PermisoRolResult>(
                "sp_ListarPermisoRol",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<PermisoRolResult>> ListByPaginationAsync(ListarPermisoRolPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarPermisoRolPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<PermisoRolResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<PermisoRolResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarPermisoRolParameters request)
        {
            var spResult = await ExecAsync<ActualizarPermisoRolParameters, SpResultBase>(
            request,
            "sp_ActualizarPermisoRol");
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
