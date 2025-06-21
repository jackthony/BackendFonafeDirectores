using Dapper;
using Sector.Application.Dtos;
using Sector.Application.Repositories;
using Sector.Domain.Models;
using Sector.Domain.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Sector.Infrastructure.Persistence.Repositories.SqlServer
{
    public class SectorSqlRepository(IDbConnection connection) : IWriteSectorRepository<SpResultBase>, IReadSectorRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SectorDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdSector", id);

            return await _connection.QueryFirstOrDefaultAsync<SectorDto>(
                "sp_ObtenerSectorPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<SectorDto>> ListAsync(ListarSectorRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<SectorDto>(
                "sp_ListarSector",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<SectorDto>> ListByPaginationAsync(ListarSectorPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarSectorPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<SectorDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<SectorDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearSectorData request)
        {
            var spResult = await ExecAsync<CrearSectorData, SpResultBase>(
            request,
            "sp_RegistrarSector");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarSectorData request)
        {
            var spResult = await ExecAsync<EliminarSectorData, SpResultBase>(
            request,
            "sp_EliminarSector");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarSectorData request)
        {
            var spResult = await ExecAsync<ActualizarSectorData, SpResultBase>(
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
