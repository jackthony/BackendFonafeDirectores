using Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.User.Dtos;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUseCase<CrearUserRequest, SpResultBase> _crearUserUseCase;

        public UserController(IUseCase<CrearUserRequest, SpResultBase> crearUserUseCase)
        {
            _crearUserUseCase = crearUserUseCase;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearUsuario([FromBody] CrearUserRequest request)
        {
            var result = await _crearUserUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }
    }
}
