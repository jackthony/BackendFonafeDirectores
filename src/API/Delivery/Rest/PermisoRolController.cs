/***********
 * Nombre del archivo:  PermisoRolController.cs
 * Descripción:         Controlador REST para la gestión de permisos por rol en el sistema.
 *                      Permite crear, actualizar, eliminar y consultar los permisos asignados a cada rol.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación completa de endpoints CRUD para PermisoRol.
 ***********/

using Api.Helpers;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Results;
using Usuario.Presentation.PermisoRol.Responses;
using Microsoft.AspNetCore.Mvc;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class PermisoRolController : ControllerBase
    {
        private readonly IUseCase<CrearPermisoRolRequest, SpResultBase> _crearPermisoRolUseCase;
        private readonly IUseCase<ActualizarPermisoRolRequest, SpResultBase> _actualizarPermisoRolUseCase;
        private readonly IUseCase<EliminarPermisoRolRequest, SpResultBase> _eliminarPermisoRolUseCase;
        private readonly IUseCase<ListarPermisoRolPaginadoRequest, PagedResult<PermisoRolResult>> _listarPermisoRolPaginadaUseCase;
        private readonly IUseCase<ListarPermisoRolRequest, List<PermisoRolResult>> _listarPermisoRolUseCase;
        private readonly IUseCase<int, PermisoRolResult?> _obtenerPermisoRolPorIdUseCase;
        private readonly IPresenterDelivery<PagedResult<PermisoRolResult>, LstItemResponse<PermisoRolResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<PermisoRolResult>, LstItemResponse<PermisoRolResponse>> _presenterList;
        private readonly IPresenterDelivery<PermisoRolResult, ItemResponse<PermisoRolResponse>> _presenterObtenerId;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;

        public PermisoRolController(IUseCase<CrearPermisoRolRequest, SpResultBase> crearPermisoRolUseCase, IUseCase<ActualizarPermisoRolRequest, SpResultBase> actualizarPermisoRolUseCase, IUseCase<EliminarPermisoRolRequest, SpResultBase> eliminarPermisoRolUseCase, IUseCase<ListarPermisoRolPaginadoRequest, PagedResult<PermisoRolResult>> listarPermisoRolPaginadaUseCase, IUseCase<ListarPermisoRolRequest, List<PermisoRolResult>> listarPermisoRolUseCase, IUseCase<int, PermisoRolResult?> obtenerPermisoRolPorIdUseCase, IPresenterDelivery<PagedResult<PermisoRolResult>, LstItemResponse<PermisoRolResponse>> presenterListPage, IPresenterDelivery<List<PermisoRolResult>, LstItemResponse<PermisoRolResponse>> presenterList, IPresenterDelivery<PermisoRolResult, ItemResponse<PermisoRolResponse>> presenterObtenerId, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt)
        {
            _crearPermisoRolUseCase = crearPermisoRolUseCase;
            _actualizarPermisoRolUseCase = actualizarPermisoRolUseCase;
            _eliminarPermisoRolUseCase = eliminarPermisoRolUseCase;
            _listarPermisoRolPaginadaUseCase = listarPermisoRolPaginadaUseCase;
            _listarPermisoRolUseCase = listarPermisoRolUseCase;
            _obtenerPermisoRolPorIdUseCase = obtenerPermisoRolPorIdUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearPermisoRol([FromBody] CrearPermisoRolRequest request)
        {
            var result = await _crearPermisoRolUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("actualizar")]
        public async Task<IActionResult> ActualizarPermisoRol([FromBody] ActualizarPermisoRolRequest request)
        {
            var result = await _actualizarPermisoRolUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("eliminar")]
        public async Task<IActionResult> EliminarPermisoRol([FromBody] EliminarPermisoRolRequest request)
        {
            var result = await _eliminarPermisoRolUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarPermisoRolPaginado([FromQuery] ListarPermisoRolPaginadoRequest request)
        {
            var result = await _listarPermisoRolPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarPermisoRol([FromQuery] ListarPermisoRolRequest request)
        {
            var result = await _listarPermisoRolUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPermisoRolPorId(int id)
        {
            var result = await _obtenerPermisoRolPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
        }
    }
}
