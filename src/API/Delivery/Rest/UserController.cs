/***********
 * Nombre del archivo:  UserController.cs
 * Descripción:         Controlador REST para gestionar usuarios. Expone endpoints para crear,
 *                      actualizar, eliminar, listar (paginado y sin paginación) y obtener un usuario
 *                      por su identificador. Utiliza casos de uso y presentadores para mapear
 *                      la lógica de negocio con las respuestas del cliente.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del controlador con endpoints CRUD.
 ***********/

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
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;

        public UserController(IUseCase<CrearUserRequest, SpResultBase> crearUserUseCase, IUseCase<ActualizarUserRequest, SpResultBase> actualizarUserUseCase, IUseCase<EliminarUserRequest, SpResultBase> eliminarUserUseCase, IUseCase<ListarUserPaginadoRequest, PagedResult<UserResult>> listarUserPaginadaUseCase, IUseCase<ListarUserRequest, List<UserResult>> listarUserUseCase, IUseCase<int, UserResult?> obtenerUserPorIdUseCase, IPresenterDelivery<PagedResult<UserResult>, LstItemResponse<UserResponse>> presenterListPage, IPresenterDelivery<List<UserResult>, LstItemResponse<UserResponse>> presenterList, IPresenterDelivery<UserResult, ItemResponse<UserResponse>> presenterObtenerId, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt)
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
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearUser([FromBody] CrearUserRequest request)
        {
            var result = await _crearUserUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("actualizar")]
        public async Task<IActionResult> ActualizarUser([FromBody] ActualizarUserRequest request)
        {
            var result = await _actualizarUserUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("eliminar")]
        public async Task<IActionResult> EliminarUser([FromBody] EliminarUserRequest request)
        {
            var result = await _eliminarUserUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
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
