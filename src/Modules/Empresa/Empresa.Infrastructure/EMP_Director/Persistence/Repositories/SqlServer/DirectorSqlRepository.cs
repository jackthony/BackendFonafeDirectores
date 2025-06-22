using Dapper;
using Empresa.Application.EMP_Director.Dtos;
using Empresa.Application.EMP_Director.Repositories;
using Empresa.Domain.EMP_Director.Models;
using Empresa.Domain.EMP_Director.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Empresa.Infrastructure.EMP_Director.Persistence.Repositories.SqlServer
{
    public class DirectorSqlRepository(IDbConnection connection) : IWriteDirectorRepository<SpResultBase>, IReadDirectorRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<DirectorDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdDirector", id);

            return await _connection.QueryFirstOrDefaultAsync<DirectorDto>(
                "sp_ObtenerDirectorPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<DirectorDto>> ListAsync(ListarDirectorRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<DirectorDto>(
                "sp_ListarDirector",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<DirectorDto>> ListByPaginationAsync(ListarDirectorPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarDirectorPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<DirectorDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<DirectorDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearDirectorData request)
        {
            var spResult = await ExecAsync<CrearDirectorData, SpResultBase>(
            request,
            "sp_RegistrarDirector");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarDirectorData request)
        {
            var spResult = await ExecAsync<EliminarDirectorData, SpResultBase>(
            request,
            "sp_EliminarDirector");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarDirectorData request)
        {
            var spResult = await ExecAsync<ActualizarDirectorData, SpResultBase>(
            request,
            "sp_ActualizarDirector");
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
