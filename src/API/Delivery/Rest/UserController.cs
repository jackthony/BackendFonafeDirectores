using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.User.Dtos;
using Usuario.Domain.User.Results;
using Usuario.Presentation.User.Responses;
using Shared.ClientV1;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUseCase<CrearUserRequest, SpResultBase> _crearUserUseCase;
        private readonly IUseCase<ActualizarUserRequest, SpResultBase> _actualizarUserUseCase;
        private readonly IUseCase<EliminarUserRequest, SpResultBase> _eliminarUserUseCase;
        private readonly IUseCase<ListarUserPaginadoRequest, PagedResult<UserResult>> _listarUserPaginadaUseCase;
        private readonly IUseCase<ListarUserRequest, List<UserResult>> _listarUserUseCase;
        private readonly IUseCase<int, UserResult?> _obtenerUserPorIdUseCase;
        private readonly IPresenterDelivery<PagedResult<UserResult>, LstItemResponse<UserResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<UserResult>, LstItemResponse<UserResponse>> _presenterList;
        private readonly IPresenterDelivery<UserResult, ItemResponse<UserResponse>> _presenterObtenerId;

        public UserController(
            IUseCase<CrearUserRequest, SpResultBase> crearUserUseCase,
            IUseCase<ActualizarUserRequest, SpResultBase> actualizarUserUseCase,
            IUseCase<EliminarUserRequest, SpResultBase> eliminarUserUseCase,
            IUseCase<ListarUserPaginadoRequest, PagedResult<UserResult>> listarUserPaginadaUseCase,
            IUseCase<ListarUserRequest, List<UserResult>> listarUserUseCase,
            IUseCase<int, UserResult?> obtenerUserPorIdUseCase,
            IPresenterDelivery<PagedResult<UserResult>, LstItemResponse<UserResponse>> presenterListPage,
            IPresenterDelivery<List<UserResult>, LstItemResponse<UserResponse>> presenterList,
            IPresenterDelivery<UserResult, ItemResponse<UserResponse>> presenterObtenerId)
        {
            _crearUserUseCase = crearUserUseCase;
            _actualizarUserUseCase = actualizarUserUseCase;
            _eliminarUserUseCase = eliminarUserUseCase;
            _listarUserPaginadaUseCase = listarUserPaginadaUseCase;
            _listarUserUseCase = listarUserUseCase;
            _obtenerUserPorIdUseCase = obtenerUserPorIdUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearUser([FromBody] CrearUserRequest request)
        {
            var result = await _crearUserUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarUser([FromBody] ActualizarUserRequest request)
        {
            var result = await _actualizarUserUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarUser([FromBody] EliminarUserRequest request)
        {
            var result = await _eliminarUserUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarUserPaginado([FromQuery] ListarUserPaginadoRequest request)
        {
            var result = await _listarUserPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarUser([FromQuery] ListarUserRequest request)
        {
            var result = await _listarUserUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerUserPorId(int id)
        {
            var result = await _obtenerUserPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
        }
    }
}
