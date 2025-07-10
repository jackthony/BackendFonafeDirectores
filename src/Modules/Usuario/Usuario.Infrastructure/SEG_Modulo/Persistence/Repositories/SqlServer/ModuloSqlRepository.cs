/***********
 * Nombre del archivo:  ModuloSqlRepository.cs
 * Descripción:         Implementación del repositorio IModuloRepository para la gestión de módulos.
 *                      Utiliza Dapper para ejecutar procedimientos almacenados que permiten operaciones
 *                      CRUD, paginación y la obtención de módulos con sus acciones según el rol.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación completa de métodos para la interacción con la base de datos.
 ***********/

using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Usuario.Domain.Modulo.Parameters;
using Usuario.Domain.Modulo.Repositories;
using Usuario.Domain.Modulo.Results;

namespace Usuario.Infrastructure.Modulo.Persistence.Repositories.SqlServer
{
    public class ModuloSqlRepository(IDbConnection connection) : IModuloRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearModuloParameters request)
        {
            var spResult = await ExecAsync<CrearModuloParameters, SpResultBase>(
            request,
            "sp_RegistrarModulo");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarModuloParameters request)
        {
            var spResult = await ExecAsync<EliminarModuloParameters, SpResultBase>(
            request,
            "sp_EliminarModulo");
            return spResult;
        }

        public async Task<ModuloResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdModulo", id);

            return await _connection.QueryFirstOrDefaultAsync<ModuloResult>(
                "sp_ObtenerModuloPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<ModuloResult>> ListAsync(ListarModuloParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<ModuloResult>(
                "sp_ListarModulo",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<ModuloResult>> ListByPaginationAsync(ListarModuloPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarModuloPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<ModuloResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<ModuloResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<List<ModuloConAccionesResult>> ListModulosWithAccionsAsync(int rolId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("RolId", rolId);

            var result = await _connection.QueryAsync<ModuloConAccionesResult>(
                "sp_ListarModulosConAcciones",
                parameters,
                commandType: CommandType.StoredProcedure);

            return [.. result];
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarModuloParameters request)
        {
            var spResult = await ExecAsync<ActualizarModuloParameters, SpResultBase>(
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
