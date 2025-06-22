using Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Usuario.Application.Auth.Dtos;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IUseCase<LoginRequest, LoginResponse> _loginUseCase;
        private readonly IUseCase<VerifyTokenRequest, LoginResponse> _verifyTokenUseCase;

        public AuthController(IUseCase<LoginRequest, LoginResponse> loginUseCase, IUseCase<VerifyTokenRequest, LoginResponse> verifyTokenUseCase)
        {
            _loginUseCase = loginUseCase;
            _verifyTokenUseCase = verifyTokenUseCase;
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
    }
}
