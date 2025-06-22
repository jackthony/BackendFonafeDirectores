using Dapper;
using OneOf.Types;
using Shared.Kernel.Responses;
using System.Data;
using Usuario.Domain.Auth.Models;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Repositories;
using Usuario.Domain.Auth.Results;

namespace Usuario.Infrastructure.Auth.Persistence.Repositories.SqlServer
{
    public class AuthRepository(IDbConnection connection) : IAuthRepository
    {
        private readonly IDbConnection _connection = connection;

        public async Task<SpResult<UsuarioResult>> ObtenerPorCorreoAsync(LoginParameters request)
        {
            using var multi = await _connection.QueryMultipleAsync(
                "sp_ProcesarLogin",
                request,
                commandType: CommandType.StoredProcedure
            );

            var spInfo = await multi.ReadFirstOrDefaultAsync<SpResultBase>();

            if (spInfo is null || !spInfo.Success)
            {
                return new SpResult<UsuarioResult>
                {
                    Success = false,
                    Message = spInfo?.Message ?? "Error desconocido",
                    Data = null
                };
            }

            var usuario = await multi.ReadFirstOrDefaultAsync<UsuarioResult>();

            return new SpResult<UsuarioResult>
            {
                Success = true,
                Message = spInfo.Message,
                Data = usuario
            };
        }
    }
}
