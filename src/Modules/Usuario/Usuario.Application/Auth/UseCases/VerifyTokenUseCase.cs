using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using System.Security.Claims;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Repositories;

namespace Usuario.Application.Auth.UseCases
{
    public class VerifyTokenUseCase : IUseCase<VerifyTokenRequest, LoginResponse>
    {
        private readonly ITokenService _tokenService;
        private readonly IAuthRepository _authRepository;

        public VerifyTokenUseCase(ITokenService tokenService, IAuthRepository authRepository)
        {
            _tokenService = tokenService;
            _authRepository = authRepository;
        }

        public async Task<OneOf<ErrorBase, LoginResponse>> ExecuteAsync(VerifyTokenRequest request)
        {
            var claimsPrincipal = _tokenService.ValidateAccessToken(request.Token);

            if (claimsPrincipal == null)
                return ErrorBase.Validation("Token inválido o expirado");

            var userCodeClaim = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier);

            if (userCodeClaim == null || string.IsNullOrWhiteSpace(userCodeClaim.Value))
                return ErrorBase.Validation("El token no contiene información del usuario");

            if (!int.TryParse(userCodeClaim.Value, out var userId))
                return ErrorBase.Validation("Formato de ID de usuario inválido en el token");

            var result = await _authRepository.ObtenerPorIdAsync(userId);

            if (!result.Success || result.Data is null)
                return ErrorBase.Database(result.Message);

            var usuario = result.Data;

            if (usuario.Status != "1")
                return ErrorBase.Validation("El usuario no se encuentra activo");

            return new LoginResponse
            {
                AccessToken = request.Token,
                UsuarioResult = usuario
            };
        }
    }
}
