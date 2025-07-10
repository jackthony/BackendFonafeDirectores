/***********
 * Nombre del archivo:  TipoDirectorSqlRepository.cs
 * Descripción:         Implementación del repositorio de TipoDirector usando Dapper y SQL Server.
 *                      Contiene operaciones CRUD y consultas paginadas a través de procedimientos almacenados.
 *                      Incluye un método genérico para ejecución de procedimientos.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial del repositorio con métodos de mantenimiento y consulta.
 ***********/

using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.TipoDirector.Parameters;
using Empresa.Domain.TipoDirector.Repositories;
using Empresa.Domain.TipoDirector.Results;

namespace Empresa.Infrastructure.TipoDirector.Persistence.Repositories.SqlServer
{
    public class TipoDirectorSqlRepository(IDbConnection connection) : ITipoDirectorRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearTipoDirectorParameters request)
        {
            var spResult = await ExecAsync<CrearTipoDirectorParameters, SpResultBase>(
            request,
            "sp_RegistrarTipoDirector");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarTipoDirectorParameters request)
        {
            var spResult = await ExecAsync<EliminarTipoDirectorParameters, SpResultBase>(
            request,
            "sp_EliminarTipoDirector");
            return spResult;
        }

        public async Task<TipoDirectorResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdTipoDirector", id);

            return await _connection.QueryFirstOrDefaultAsync<TipoDirectorResult>(
                "sp_ObtenerTipoDirectorPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<TipoDirectorResult>> ListAsync(ListarTipoDirectorParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<TipoDirectorResult>(
                "sp_ListarTipoDirector",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<TipoDirectorResult>> ListByPaginationAsync(ListarTipoDirectorPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarTipoDirectorPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<TipoDirectorResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<TipoDirectorResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarTipoDirectorParameters request)
        {
            var spResult = await ExecAsync<ActualizarTipoDirectorParameters, SpResultBase>(
            request,
            "sp_ActualizarTipoDirector");
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
