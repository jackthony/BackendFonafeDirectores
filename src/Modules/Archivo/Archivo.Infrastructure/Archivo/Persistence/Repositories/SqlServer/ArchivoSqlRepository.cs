/*****
 * Nombre del archivo:  ArchivoSqlRepository.cs
 * Descripción:         Implementación del repositorio `IArchivoRepository` para la base de datos SQL Server utilizando Dapper. 
 *                      Contiene métodos para agregar, actualizar, eliminar, obtener y listar archivos, 
 *                      ejecutando procedimientos almacenados correspondientes para cada operación.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Archivo.Domain.Archivo.Parameters;
using Archivo.Domain.Archivo.Repositories;
using Archivo.Domain.Archivo.Results;

namespace Archivo.Infrastructure.Archivo.Persistence.Repositories.SqlServer
{
    public class ArchivoSqlRepository(IDbConnection connection) : IArchivoRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearArchivoParameters request)
        {
            var spResult = await ExecAsync<CrearArchivoParameters, SpResultBase>(
            request,
            "sp_RegistrarArchivo");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarArchivoParameters request)
        {
            var spResult = await ExecAsync<EliminarArchivoParameters, SpResultBase>(
            request,
            "sp_EliminarArchivo");
            return spResult;
        }

        public async Task<ArchivoResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdArchivo", id);

            return await _connection.QueryFirstOrDefaultAsync<ArchivoResult>(
                "sp_ObtenerArchivoPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<ArchivoResult>> ListAsync(ListarArchivoParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<ArchivoResult>(
                "sp_ListarArchivo",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<ArchivoResult>> ListByPaginationAsync(ListarArchivoPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarArchivoPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<ArchivoResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<ArchivoResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarArchivoParameters request)
        {
            var spResult = await ExecAsync<ActualizarArchivoParameters, SpResultBase>(
            request,
            "sp_ActualizarArchivo");
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
