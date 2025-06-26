using Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.Auth.Dtos;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUseCase<LoginRequest, LoginResponse> _loginUseCase;
        private readonly IUseCase<VerifyTokenRequest, LoginResponse> _verifyTokenUseCase;
        private readonly IUseCase<RefreshTokenRequest, LoginResponse> _refreshTokenUseCase;
        private readonly IUseCase<ChangePasswordRequest, SpResultBase> _changePasswordUseCase;

        public AuthController(IUseCase<LoginRequest, LoginResponse> loginUseCase, IUseCase<VerifyTokenRequest, LoginResponse> verifyTokenUseCase, IUseCase<RefreshTokenRequest, LoginResponse> refreshTokenUseCase, IUseCase<ChangePasswordRequest, SpResultBase> changePasswordUseCase)
        {
            _loginUseCase = loginUseCase;
            _verifyTokenUseCase = verifyTokenUseCase;
            _refreshTokenUseCase = refreshTokenUseCase;
            _changePasswordUseCase = changePasswordUseCase;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = await _loginUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            return Ok(result.AsT1);
        }

        [HttpPost("verify-token")]
        public async Task<IActionResult> VerifyToken([FromBody] VerifyTokenRequest request)
        {
            var result = await _verifyTokenUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            return Ok(result.AsT1);
        }

        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenRequest request)
        {
            var result = await _refreshTokenUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            return Ok(result.AsT1);
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordRequest request)
        {
            var result = await _changePasswordUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);

        }
    }
}
