using Dapper;
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

        public async Task IncrementarIntentosFallidosAsync(int usuarioId)
        {
            await _connection.ExecuteAsync(
                "sp_IncrementarIntentosFallidos",
                new { UsuarioId = usuarioId },
                commandType: CommandType.StoredProcedure
            );
        }

        public async Task GuardarRefreshToken(RefreshToken refreshToken)
        {
            var parameters = new DynamicParameters(refreshToken);

            await _connection.ExecuteAsync(
                "sp_RegistrarRefreshToken",
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }

        public Task<SpResult<UsuarioResult>> ObtenerPorCorreoAsync(LoginParameters request)
        {
            return EjecutarSpConResultadoAsync<UsuarioResult>(
                "sp_ProcesarLogin",
                request
            );
        }

        public Task<SpResult<UsuarioResult>> ObtenerPorIdAsync(int usuarioId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("UsuarioId", usuarioId);

            return EjecutarSpConResultadoAsync<UsuarioResult>(
                "sp_ProcesarLoginById",
                parameters
            );
        }

        private async Task<SpResult<T>> EjecutarSpConResultadoAsync<T>(string storedProcedure, object parameters)
        {
            using var multi = await _connection.QueryMultipleAsync(
                storedProcedure,
                parameters,
                commandType: CommandType.StoredProcedure
            );

            var spInfo = await multi.ReadFirstOrDefaultAsync<SpResultBase>();

            if (spInfo is null || !spInfo.Success)
            {
                return new SpResult<T>
                {
                    Success = false,
                    Message = spInfo?.Message ?? "Error desconocido",
                    Data = default
                };
            }

            var data = await multi.ReadFirstOrDefaultAsync<T>();

            return new SpResult<T>
            {
                Success = true,
                Message = spInfo.Message,
                Data = data
            };
        }

        public async Task<RefreshToken> ObtenerRefreshTokenAsync(string token)
        {
            var parameters = new DynamicParameters();
            parameters.Add("Token", token);

            return await _connection.QueryFirstAsync<RefreshToken>(
                "sp_ObtenerRefreshToken",
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }
    }
}
