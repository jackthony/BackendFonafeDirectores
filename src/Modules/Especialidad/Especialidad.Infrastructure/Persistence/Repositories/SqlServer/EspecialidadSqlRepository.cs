using Dapper;
using Especialidad.Application.Dtos;
using Especialidad.Application.Repositories;
using Especialidad.Domain.Models;
using Especialidad.Domain.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Especialidad.Infrastructure.Persistence.Repositories.SqlServer
{
    public class EspecialidadSqlRepository(IDbConnection connection) : IWriteEspecialidadRepository<SpResultBase>, IReadEspecialidadRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<EspecialidadDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdEspecialidad", id);

            return await _connection.QueryFirstOrDefaultAsync<EspecialidadDto>(
                "sp_ObtenerEspecialidadPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<EspecialidadDto>> ListAsync(ListarEspecialidadRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<EspecialidadDto>(
                "sp_ListarEspecialidad",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<EspecialidadDto>> ListByPaginationAsync(ListarEspecialidadPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarEspecialidadPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<EspecialidadDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<EspecialidadDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearEspecialidadData request)
        {
            var spResult = await ExecAsync<CrearEspecialidadData, SpResultBase>(
            request,
            "sp_RegistrarEspecialidad");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarEspecialidadData request)
        {
            var spResult = await ExecAsync<EliminarEspecialidadData, SpResultBase>(
            request,
            "sp_EliminarEspecialidad");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarEspecialidadData request)
        {
            var spResult = await ExecAsync<ActualizarEspecialidadData, SpResultBase>(
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
