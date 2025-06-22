using Dapper;
using Empresa.Application.EMP_TipoDirector.Dtos;
using Empresa.Application.EMP_TipoDirector.Repositories;
using Empresa.Domain.EMP_TipoDirector.Models;
using Empresa.Domain.EMP_TipoDirector.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Empresa.Infrastructure.EMP_TipoDirector.Persistence.Repositories.SqlServer
{
    public class TipoDirectorSqlRepository(IDbConnection connection) : IWriteTipoDirectorRepository<SpResultBase>, IReadTipoDirectorRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<TipoDirectorDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdTipoDirector", id);

            return await _connection.QueryFirstOrDefaultAsync<TipoDirectorDto>(
                "sp_ObtenerTipoDirectorPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<TipoDirectorDto>> ListAsync(ListarTipoDirectorRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<TipoDirectorDto>(
                "sp_ListarTipoDirector",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<TipoDirectorDto>> ListByPaginationAsync(ListarTipoDirectorPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarTipoDirectorPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<TipoDirectorDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<TipoDirectorDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearTipoDirectorData request)
        {
            var spResult = await ExecAsync<CrearTipoDirectorData, SpResultBase>(
            request,
            "sp_RegistrarTipoDirector");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarTipoDirectorData request)
        {
            var spResult = await ExecAsync<EliminarTipoDirectorData, SpResultBase>(
            request,
            "sp_EliminarTipoDirector");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarTipoDirectorData request)
        {
            var spResult = await ExecAsync<ActualizarTipoDirectorData, SpResultBase>(
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
