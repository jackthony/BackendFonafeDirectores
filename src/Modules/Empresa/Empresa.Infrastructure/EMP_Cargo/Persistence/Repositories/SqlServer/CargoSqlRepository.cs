/***********
 * Nombre del archivo:  CargoSqlRepository.cs
 * Descripción:         Implementación del repositorio del módulo Cargo utilizando Dapper y SQL Server.
 *                      Proporciona métodos para registrar, actualizar, eliminar, listar y paginar cargos
 *                      a través de procedimientos almacenados, incluyendo un método genérico para su ejecución.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial del repositorio con lógica de acceso a datos del módulo Cargo.
 ***********/

using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.Cargo.Parameters;
using Empresa.Domain.Cargo.Repositories;
using Empresa.Domain.Cargo.Results;

namespace Empresa.Infrastructure.Cargo.Persistence.Repositories.SqlServer
{
    public class CargoSqlRepository(IDbConnection connection) : ICargoRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearCargoParameters request)
        {
            var spResult = await ExecAsync<CrearCargoParameters, SpResultBase>(
            request,
            "sp_RegistrarCargo");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarCargoParameters request)
        {
            var spResult = await ExecAsync<EliminarCargoParameters, SpResultBase>(
            request,
            "sp_EliminarCargo");
            return spResult;
        }

        public async Task<CargoResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdCargo", id);

            return await _connection.QueryFirstOrDefaultAsync<CargoResult>(
                "sp_ObtenerCargoPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<CargoResult>> ListAsync(ListarCargoParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<CargoResult>(
                "sp_ListarCargo",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<CargoResult>> ListByPaginationAsync(ListarCargoPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarCargoPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<CargoResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<CargoResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarCargoParameters request)
        {
            var spResult = await ExecAsync<ActualizarCargoParameters, SpResultBase>(
            request,
            "sp_ActualizarCargo");
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
