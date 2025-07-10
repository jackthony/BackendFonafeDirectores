/***********
 * Nombre del archivo:  EmpresaSqlRepository.cs
 * Descripción:         Implementación del repositorio del módulo Empresa utilizando Dapper y SQL Server.
 *                      Proporciona métodos para registrar, actualizar, eliminar, listar y paginar empresas
 *                      mediante procedimientos almacenados. Incluye un método genérico para ejecución de SPs.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del repositorio con operaciones de mantenimiento y consulta.
 ***********/

using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.Empresa.Parameters;
using Empresa.Domain.Empresa.Repositories;
using Empresa.Domain.Empresa.Results;

namespace Empresa.Infrastructure.Empresa.Persistence.Repositories.SqlServer
{
    public class EmpresaSqlRepository(IDbConnection connection) : IEmpresaRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearEmpresaParameters request)
        {
            var spResult = await ExecAsync<CrearEmpresaParameters, SpResultBase>(
            request,
            "sp_RegistrarEmpresa");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarEmpresaParameters request)
        {
            var spResult = await ExecAsync<EliminarEmpresaParameters, SpResultBase>(
            request,
            "sp_EliminarEmpresa");
            return spResult;
        }

        public async Task<EmpresaResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdEmpresa", id);

            return await _connection.QueryFirstOrDefaultAsync<EmpresaResult>(
                "sp_ObtenerEmpresaPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<EmpresaResult>> ListAsync(ListarEmpresaParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<EmpresaResult>(
                "sp_ListarEmpresa",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<EmpresaResult>> ListByPaginationAsync(ListarEmpresaPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarEmpresaPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<EmpresaResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<EmpresaResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarEmpresaParameters request)
        {
            var spResult = await ExecAsync<ActualizarEmpresaParameters, SpResultBase>(
            request,
            "sp_ActualizarEmpresa");
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
