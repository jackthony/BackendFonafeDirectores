using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Time;
using System.Text.Json;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Models;
using Usuario.Domain.Auth.Repositories;
using Usuario.Domain.SEG_Modulo.Models;

namespace Usuario.Application.Auth.UseCases
{
    public class RefreshTokenUseCase : IUseCase<RefreshTokenRequest, LoginResponse>
    {
        private readonly IAuthRepository _authRepository;
        private readonly ITokenService _tokenService;
        private readonly ITimeProvider _timeProvider;

        public RefreshTokenUseCase(IAuthRepository authRepository, ITokenService tokenService, ITimeProvider timeProvider)
        {
            _authRepository = authRepository;
            _tokenService = tokenService;
            _timeProvider = timeProvider;
        }

        public async Task<OneOf<ErrorBase, LoginResponse>> ExecuteAsync(RefreshTokenRequest request)
        {
            var userId = _tokenService.GetUserIdFromExpiredToken(request.sAccessToken);
            if (userId is null)
                return ErrorBase.Validation("Access token inválido");

            // 2. Obtener el token de la base de datos
            var refreshTokenResult = await _authRepository.ObtenerRefreshTokenAsync(request.sRefreshToken);

            if (refreshTokenResult != null)
                return ErrorBase.Validation("Refresh token no encontrado");


            if (refreshTokenResult!.UsuarioId != userId)
                return ErrorBase.Validation("El refresh token no pertenece al usuario");

            if (refreshTokenResult.Revocado || refreshTokenResult.Expiracion <= _timeProvider.NowPeru)
                return ErrorBase.Validation("Refresh token expirado o revocado");

            /*// 3. Revocar el refresh token anterior (opcional rotación)
            await _authRepository.RevocarRefreshTokenAsync(refreshTokenResult.RefreshTokenId);

            // 4. Generar nuevo token
            var newRefreshToken = _tokenService.GenerateRefreshToken();

            // 5. Guardar nuevo refresh token
            var nuevoRefresh = new RefreshToken
            {
                UsuarioId = storedToken.UsuarioId,
                Token = newRefreshToken,
                Expiracion = DateTime.UtcNow.AddDays(7),
                IpRegistro = null // opcional
            };

            await _authRepository.GuardarRefreshToken(nuevoRefresh);
            */
            // 6. Obtener permisos para reconstruir la respuesta igual que en login

            var usuarioResult = await _authRepository.ObtenerPorIdAsync(refreshTokenResult.UsuarioId);
            var newAccessToken = _tokenService.GenerateAccessToken(refreshTokenResult.UsuarioId, usuarioResult.Data!.CorreoElectronico, []);

            if (!usuarioResult.Success || usuarioResult.Data is null)
                return ErrorBase.Database("No se pudo obtener el usuario");

            var usuario = usuarioResult.Data;

            var modulosPermisos = JsonSerializer.Deserialize<List<ModuloPermiso>>(usuario.JsonModulos) ?? [];

            return new LoginResponse
            {
                AccessToken = newAccessToken,
                Modulos = modulosPermisos,
                UsuarioResult = usuario,
                RefreshToken = refreshTokenResult.Token
            };
        }
    }
}
