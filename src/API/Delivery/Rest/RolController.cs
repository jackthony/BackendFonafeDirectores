﻿/***********
 * Nombre del archivo:  RolController.cs
 * Descripción:         Controlador REST para la gestión de Roles y permisos. Permite realizar operaciones
 *                      CRUD sobre roles del sistema, así como asignar permisos mediante el caso de uso
 *                      CrearPermisosRol.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación completa de endpoints para roles y asignación de permisos.
 ***********/

using Api.Helpers;
using Usuario.Application.Rol.Dtos;
using Usuario.Domain.Rol.Results;
using Usuario.Presentation.Rol.Responses;
using Microsoft.AspNetCore.Mvc;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Application.SEG_Rol.Dtos;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class RolController : ControllerBase
    {
        private readonly IUseCase<CrearRolRequest, SpResultBase> _crearRolUseCase;
        private readonly IUseCase<ActualizarRolRequest, SpResultBase> _actualizarRolUseCase;
        private readonly IUseCase<EliminarRolRequest, SpResultBase> _eliminarRolUseCase;
        private readonly IUseCase<ListarRolPaginadoRequest, PagedResult<RolResult>> _listarRolPaginadaUseCase;
        private readonly IUseCase<ListarRolRequest, List<RolResult>> _listarRolUseCase;
        private readonly IUseCase<int, RolResult?> _obtenerRolPorIdUseCase;
        private readonly IUseCase<CrearPermisosRolRequest, SpResultBase> _crearPermisosRolUseCase;
        private readonly IPresenterDelivery<PagedResult<RolResult>, LstItemResponse<RolResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<RolResult>, LstItemResponse<RolResponse>> _presenterList;
        private readonly IPresenterDelivery<RolResult, ItemResponse<RolResponse>> _presenterObtenerId;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;

        public RolController(IUseCase<CrearRolRequest, SpResultBase> crearRolUseCase, IUseCase<ActualizarRolRequest, SpResultBase> actualizarRolUseCase, IUseCase<EliminarRolRequest, SpResultBase> eliminarRolUseCase, IUseCase<ListarRolPaginadoRequest, PagedResult<RolResult>> listarRolPaginadaUseCase, IUseCase<ListarRolRequest, List<RolResult>> listarRolUseCase, IUseCase<int, RolResult?> obtenerRolPorIdUseCase, IUseCase<CrearPermisosRolRequest, SpResultBase> crearPermisosRolUseCase, IPresenterDelivery<PagedResult<RolResult>, LstItemResponse<RolResponse>> presenterListPage, IPresenterDelivery<List<RolResult>, LstItemResponse<RolResponse>> presenterList, IPresenterDelivery<RolResult, ItemResponse<RolResponse>> presenterObtenerId, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt)
        {
            _crearRolUseCase = crearRolUseCase;
            _actualizarRolUseCase = actualizarRolUseCase;
            _eliminarRolUseCase = eliminarRolUseCase;
            _listarRolPaginadaUseCase = listarRolPaginadaUseCase;
            _listarRolUseCase = listarRolUseCase;
            _obtenerRolPorIdUseCase = obtenerRolPorIdUseCase;
            _crearPermisosRolUseCase = crearPermisosRolUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
        }

        [HttpPost("crearPermisosRol")]
        public async Task<IActionResult> CrearRol([FromBody] CrearPermisosRolRequest request)
        {
            var result = await _crearPermisosRolUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearRol([FromBody] CrearRolRequest request)
        {
            var result = await _crearRolUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("actualizar")]
        public async Task<IActionResult> ActualizarRol([FromBody] ActualizarRolRequest request)
        {
            var result = await _actualizarRolUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("eliminar")]
        public async Task<IActionResult> EliminarRol([FromBody] EliminarRolRequest request)
        {
            var result = await _eliminarRolUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarRolPaginado([FromQuery] ListarRolPaginadoRequest request)
        {
            var result = await _listarRolPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarRol([FromQuery] ListarRolRequest request)
        {
            var result = await _listarRolUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerRolPorId(int id)
        {
            var result = await _obtenerRolPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
        }
    }
}
