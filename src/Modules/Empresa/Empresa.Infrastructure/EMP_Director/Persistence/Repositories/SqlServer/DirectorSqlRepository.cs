/***********
 * Nombre del archivo:  DirectorSqlRepository.cs
 * Descripción:         Implementación del repositorio del módulo Director utilizando Dapper y SQL Server.
 *                      Incluye operaciones para registrar, actualizar, eliminar, listar y paginar directores,
 *                      además de una consulta adicional para obtener el número de miembros de una empresa.
 *                      Utiliza procedimientos almacenados y un método genérico para su ejecución.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del repositorio con lógica adicional para consulta directa de miembros.
 ***********/

using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.Director.Parameters;
using Empresa.Domain.Director.Repositories;
using Empresa.Domain.Director.Results;

namespace Empresa.Infrastructure.Director.Persistence.Repositories.SqlServer
{
    public class DirectorSqlRepository(IDbConnection connection) : IDirectorRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearDirectorParameters request)
        {
            var spResult = await ExecAsync<CrearDirectorParameters, SpResultBase>(
            request,
            "sp_RegistrarDirector");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarDirectorParameters request)
        {
            var spResult = await ExecAsync<EliminarDirectorParameters, SpResultBase>(
            request,
            "sp_EliminarDirector");
            return spResult;
        }

        public async Task<DirectorResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();

            parameters.Add("IdDirector", id);

            return await _connection.QueryFirstOrDefaultAsync<DirectorResult>(
                "sp_ObtenerDirectorPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<int> GetNumeroMiembros(int empresaId)
        {
            var query = "SELECT nNumeroMiembros FROM EMP_Empresa WHERE nEmpresaId = @EmpresaId";
            var result = await _connection.ExecuteScalarAsync<int>(query, new { EmpresaId = empresaId });
            return result;
        }

        public async Task<List<DirectorResult>> ListAsync(ListarDirectorParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<DirectorResult>(
                "sp_ListarDirector",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<DirectorResult>> ListByPaginationAsync(ListarDirectorPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarDirectorPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<DirectorResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<DirectorResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarDirectorParameters request)
        {
            var spResult = await ExecAsync<ActualizarDirectorParameters, SpResultBase>(
            request,
            "sp_ActualizarDirector");
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
