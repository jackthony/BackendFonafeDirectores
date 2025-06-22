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

        public AuthController(IUseCase<LoginRequest, LoginResponse> loginUseCase)
        {
            _loginUseCase = loginUseCase;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var result = await _loginUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            return Ok(result.AsT1);
        }
    }
}
