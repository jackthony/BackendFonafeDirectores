/***********
 * Nombre del archivo:  AuthRepository.cs
 * Descripción:         Implementación del repositorio de autenticación que gestiona el login de usuarios,
 *                      manejo de tokens (refresh, revocación), intentos fallidos, cambio de contraseña,
 *                      y recuperación de administradores. Utiliza procedimientos almacenados y Dapper.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Inclusión de lógica para recuperación de cuenta, cambio de contraseña y validación por token.
 ***********/

using Dapper;
using Org.BouncyCastle.Asn1.Ocsp;
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


        // ─────────── Nuevos métodos para gestión de contraseña ───────────
        public async Task<SpResultBase> UpdatePasswordAsync(ChangePasswordParameters parameters)
        {
            var spResult = await ExecAsync<ChangePasswordParameters, SpResultBase>(
                parameters,
                "sp_ActualizarPassword"
            );
            return spResult;
        }

        public async Task<SpResultBase> ClearFailedAttemptsAsync(ClearFailedAttemptsParameters parameters)
        {
            var spResult = await ExecAsync<ClearFailedAttemptsParameters, SpResultBase>(
                parameters,
                "sp_LimpiarIntentosFallidos"
            );
            return spResult;
        }

        //public async Task LogPasswordChangeAsync(int usuarioId, string actor)
        //{
        //    var parameters = new DynamicParameters();
        //    parameters.Add("UsuarioId", usuarioId);
        //    parameters.Add("Actor", actor);
        //    parameters.Add("ChangeDate", DateTime.UtcNow);

        //    await _connection.ExecuteAsync(
        //        "sp_RegistrarCambioContrasena",
        //        parameters,
        //        commandType: CommandType.StoredProcedure
        //    );
        //}

        // ──────────────────────────────────────────────────────────────────



        // Store para revocar token
        public async Task<SpResultBase> RevocarRefreshTokenAsync (LogoutParameters parameters)
        {
            var spResult = await ExecAsync<LogoutParameters, SpResultBase>(
                parameters,
                "sp_RevocarToken"
            );
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

        public async Task<SpResultBase> ConfirmarCuentaAsync(int userId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("UsuarioId", userId);

            return await _connection.QueryFirstAsync<SpResultBase>(
                "sp_ConfirmarCuenta",
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }

        public async Task<List<string>> RecoveryAdminsAsync()
        {
            var query = "SELECT sCorreoElectronico FROM SEG_Usuario u INNER JOIN SEG_UsuarioRol ur ON u.nUsuarioId = ur.nUsuarioId INNER JOIN SEG_Rol r ON r.nRolId = ur.nRolId WHERE r.nRolId = 1";
            var result = await _connection.QueryAsync<string>(query);
            return [.. result];
        }
    }
}
