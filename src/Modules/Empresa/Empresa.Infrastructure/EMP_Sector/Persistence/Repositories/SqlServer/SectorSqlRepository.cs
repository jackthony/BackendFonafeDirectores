/***********
 * Nombre del archivo:  SectorSqlRepository.cs
 * Descripción:         Implementación del repositorio de Sector utilizando Dapper y SQL Server.
 *                      Contiene operaciones para registrar, actualizar, eliminar, listar y paginar sectores
 *                      mediante procedimientos almacenados. Incluye un método genérico para ejecutar SPs.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial del repositorio con operaciones de mantenimiento y consulta.
 ***********/

using Dapper;
using Shared.Kernel.Responses;
using System.Data;
using Empresa.Domain.Sector.Parameters;
using Empresa.Domain.Sector.Repositories;
using Empresa.Domain.Sector.Results;

namespace Empresa.Infrastructure.Sector.Persistence.Repositories.SqlServer
{
    public class SectorSqlRepository(IDbConnection connection) : ISectorRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResultBase> AddAsync(CrearSectorParameters request)
        {
            var spResult = await ExecAsync<CrearSectorParameters, SpResultBase>(
            request,
            "sp_RegistrarSector");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarSectorParameters request)
        {
            var spResult = await ExecAsync<EliminarSectorParameters, SpResultBase>(
            request,
            "sp_EliminarSector");
            return spResult;
        }

        public async Task<SectorResult?> GetByIdAsync(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdSector", id);

            return await _connection.QueryFirstOrDefaultAsync<SectorResult>(
                "sp_ObtenerSectorPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<SectorResult>> ListAsync(ListarSectorParameters request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<SectorResult>(
                "sp_ListarSector",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<SectorResult>> ListByPaginationAsync(ListarSectorPaginadoParameters request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarSectorPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<SectorResult>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<SectorResult>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarSectorParameters request)
        {
            var spResult = await ExecAsync<ActualizarSectorParameters, SpResultBase>(
            request,
            "sp_ActualizarSector");
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
