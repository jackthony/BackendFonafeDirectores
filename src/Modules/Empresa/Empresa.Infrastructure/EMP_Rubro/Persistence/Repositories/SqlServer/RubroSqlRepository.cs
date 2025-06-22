using Dapper;
using Empresa.Application.EMP_Rubro.Dtos;
using Empresa.Application.EMP_Rubro.Repositories;
using Empresa.Domain.EMP_Rubro.Models;
using Empresa.Domain.EMP_Rubro.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Empresa.Infrastructure.EMP_Rubro.Persistence.Repositories.SqlServer
{
    public class RubroSqlRepository(IDbConnection connection) : IWriteRubroRepository<SpResultBase>, IReadRubroRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<RubroDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdRubro", id);

            return await _connection.QueryFirstOrDefaultAsync<RubroDto>(
                "sp_ObtenerRubroPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<RubroDto>> ListAsync(ListarRubroRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<RubroDto>(
                "sp_ListarRubro",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<RubroDto>> ListByPaginationAsync(ListarRubroPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarRubroPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<RubroDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<RubroDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearRubroData request)
        {
            var spResult = await ExecAsync<CrearRubroData, SpResultBase>(
            request,
            "sp_RegistrarRubro");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarRubroData request)
        {
            var spResult = await ExecAsync<EliminarRubroData, SpResultBase>(
            request,
            "sp_EliminarRubro");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarRubroData request)
        {
            var spResult = await ExecAsync<ActualizarRubroData, SpResultBase>(
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
