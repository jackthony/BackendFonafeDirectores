/***********
 * Nombre del archivo:  EspecialidadSqlRepository.cs
 * Descripción:         Implementación del repositorio del módulo Especialidad utilizando Dapper y SQL Server.
 *                      Provee métodos para registrar, actualizar, eliminar, listar y paginar especialidades
 *                      mediante procedimientos almacenados. Incluye un método genérico para ejecutar SPs.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial del repositorio con operaciones de acceso a datos para Especialidad.
 ***********/

using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.Especialidad.Parameters;
using Empresa.Domain.Especialidad.Repositories;
using Empresa.Domain.Especialidad.Results;

namespace Empresa.Infrastructure.Especialidad.Persistence.Repositories.SqlServer
{
    public class EspecialidadSqlRepository(IDbConnection connection) : IEspecialidadRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearEspecialidadParameters request)
        {
            var spResult = await ExecAsync<CrearEspecialidadParameters, SpResultBase>(
            request,
            "sp_RegistrarEspecialidad");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarEspecialidadParameters request)
        {
            var spResult = await ExecAsync<EliminarEspecialidadParameters, SpResultBase>(
            request,
            "sp_EliminarEspecialidad");
            return spResult;
        }

        public async Task<EspecialidadResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();

            parameters.Add("IdEspecialidad", id);

            return await _connection.QueryFirstOrDefaultAsync<EspecialidadResult>(
                "sp_ObtenerEspecialidadPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<EspecialidadResult>> ListAsync(ListarEspecialidadParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<EspecialidadResult>(
                "sp_ListarEspecialidad",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<EspecialidadResult>> ListByPaginationAsync(ListarEspecialidadPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarEspecialidadPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<EspecialidadResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<EspecialidadResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarEspecialidadParameters request)
        {
            var spResult = await ExecAsync<ActualizarEspecialidadParameters, SpResultBase>(
            request,
            "sp_ActualizarEspecialidad");
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
