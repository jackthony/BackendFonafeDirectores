using Dapper;
using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Application.EMP_Empresa.Repositories;
using Empresa.Domain.EMP_Empresa.Models;
using Empresa.Domain.EMP_Empresa.Repositories;
using Shared.Kernel.Responses;
using System.Data;

namespace Empresa.Infrastructure.EMP_Empresa.Persistence.Repositories.SqlServer
{
    public class EmpresaSqlRepository(IDbConnection connection) : IWriteEmpresaRepository<SpResultBase>, IReadEmpresaRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<EmpresaDto?> GetByIdAsync(long id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("IdEmpresa", id);

            return await _connection.QueryFirstOrDefaultAsync<EmpresaDto>(
                "sp_ObtenerEmpresaPorId",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        public async Task<List<EmpresaDto>> ListAsync(ListarEmpresaRequest request)
        {
            var parameters = new DynamicParameters(request);

            var result = await _connection.QueryAsync<EmpresaDto>(
                "sp_ListarEmpresa",
                parameters,
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<PagedResult<EmpresaDto>> ListByPaginationAsync(ListarEmpresaPaginadoRequest request)
        {
            var parameters = new DynamicParameters(request);

            using var multi = await _connection.QueryMultipleAsync(
                "sp_ListarEmpresaPaginado",
                parameters,
                commandType: CommandType.StoredProcedure);

            var items = (await multi.ReadAsync<EmpresaDto>()).ToList();
            var total = await multi.ReadFirstAsync<int>();

            return new PagedResult<EmpresaDto>()
            {
                Items = items,
                Page = request.Page,
                PageSize = request.PageSize,
                TotalItems = total
            };
        }

        public async Task<SpResultBase> AddAsync(CrearEmpresaData request)
        {
            var spResult = await ExecAsync<CrearEmpresaData, SpResultBase>(
            request,
            "sp_RegistrarEmpresa");
            return spResult;
        }

        public async Task<SpResultBase> DeleteAsync(EliminarEmpresaData request)
        {
            var spResult = await ExecAsync<EliminarEmpresaData, SpResultBase>(
            request,
            "sp_EliminarEmpresa");
            return spResult;
        }

        public async Task<SpResultBase> UpdateAsync(ActualizarEmpresaData request)
        {
            var spResult = await ExecAsync<ActualizarEmpresaData, SpResultBase>(
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
