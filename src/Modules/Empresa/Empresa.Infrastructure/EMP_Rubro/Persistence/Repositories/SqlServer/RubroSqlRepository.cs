/***********
 * Nombre del archivo:  RubroSqlRepository.cs
 * Descripción:         Implementación del repositorio de Rubro utilizando Dapper y SQL Server.
 *                      Incluye operaciones CRUD, paginación y consultas mediante procedimientos almacenados.
 *                      Se utiliza un método genérico para ejecutar los procedimientos.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial del repositorio con lógica de acceso a datos para el módulo Rubro.
 ***********/

using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.Rubro.Parameters;
using Empresa.Domain.Rubro.Repositories;
using Empresa.Domain.Rubro.Results;

namespace Empresa.Infrastructure.Rubro.Persistence.Repositories.SqlServer
{
    public class RubroSqlRepository(IDbConnection connection) : IRubroRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearRubroParameters request)
        {
            var spResult = await ExecAsync<CrearRubroParameters, SpResultBase>(
            request,
            "sp_RegistrarRubro");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarRubroParameters request)
        {
            var spResult = await ExecAsync<EliminarRubroParameters, SpResultBase>(
            request,
            "sp_EliminarRubro");
            return spResult;
        }

        public async Task<RubroResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdRubro", id);
            return await _connection.QueryFirstOrDefaultAsync<RubroResult>(
                "sp_ObtenerRubroPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<RubroResult>> ListAsync(ListarRubroParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<RubroResult>(
                "sp_ListarRubro",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<RubroResult>> ListByPaginationAsync(ListarRubroPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarRubroPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<RubroResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<RubroResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarRubroParameters request)
        {
            var spResult = await ExecAsync<ActualizarRubroParameters, SpResultBase>(
            request,
            "sp_ActualizarRubro");
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
