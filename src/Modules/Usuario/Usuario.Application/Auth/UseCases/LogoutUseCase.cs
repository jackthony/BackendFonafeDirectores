using System.Security.Claims;
using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Auth.Dtos;
using Usuario.Application.Auth.Services;
using Usuario.Domain.Auth.Parameters;
using Usuario.Domain.Auth.Repositories;
using Usuario.Domain.SEG_Modulo.Models;

namespace Usuario.Application.Auth.UseCases
{
    public class LogoutUseCase : IUseCase<VerifyTokenRequest, SpResultBase>
    {
        private readonly ITokenService _tokenService;
        private readonly IAuthRepository _authRepository;


        public LogoutUseCase(ITokenService tokenService, IAuthRepository authRepository)
        {
            _tokenService = tokenService;
            _authRepository = authRepository;
        }

        public async Task<OneOf<ErrorBase, SpResultBase>> ExecuteAsync(VerifyTokenRequest request)
        {
            // Validar el token de acceso
            var claimsPrincipal = _tokenService.ValidateAccessToken(request.Token);
            if (claimsPrincipal == null)
                return ErrorBase.Validation("Token inválido o expirado");
            // Obtener el ID del usuario desde el token
            var userCodeClaim = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier);
            if (userCodeClaim == null || string.IsNullOrWhiteSpace(userCodeClaim.Value))
                return ErrorBase.Validation("El token no contiene información del usuario");
            if (!int.TryParse(userCodeClaim.Value, out var userId))
                return ErrorBase.Validation("Formato de ID de usuario inválido en el token");

            LogoutParameters requestParameters = new LogoutParameters
            {
                UserId = userId
            };
            // Revocar el refresh token asociado al usuario
            var result = await _authRepository.RevocarRefreshTokenAsync(requestParameters);

            return result;
        }
    }
}
