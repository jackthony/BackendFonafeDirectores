﻿/***********
 * Nombre del archivo:  RubroController.cs
 * Descripción:         Controlador REST para la gestión del catálogo de Rubros empresariales. Proporciona
 *                      endpoints para operaciones de creación, actualización, eliminación, obtención por ID
 *                      y listado (con y sin paginación), delegando la lógica a los casos de uso y mapeadores.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación CRUD completa para el módulo Rubro.
 ***********/

using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Results;
using Empresa.Presentation.Rubro.Responses;
using Shared.ClientV1;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class RubroController : ControllerBase
    {
        private readonly IUseCase<CrearRubroRequest, SpResultBase> _crearRubroUseCase;
        private readonly IUseCase<ActualizarRubroRequest, SpResultBase> _actualizarRubroUseCase;
        private readonly IUseCase<EliminarRubroRequest, SpResultBase> _eliminarRubroUseCase;
        private readonly IUseCase<ListarRubroPaginadoRequest, PagedResult<RubroResult>> _listarRubroPaginadaUseCase;
        private readonly IUseCase<ListarRubroRequest, List<RubroResult>> _listarRubroUseCase;
        private readonly IUseCase<int, RubroResult?> _obtenerRubroPorIdUseCase;
        private readonly IPresenterDelivery<PagedResult<RubroResult>, LstItemResponse<RubroResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<RubroResult>, LstItemResponse<RubroResponse>> _presenterList;
        private readonly IPresenterDelivery<RubroResult, ItemResponse<RubroResponse>> _presenterObtenerId;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;

        public RubroController(IUseCase<CrearRubroRequest, SpResultBase> crearRubroUseCase, IUseCase<ActualizarRubroRequest, SpResultBase> actualizarRubroUseCase, IUseCase<EliminarRubroRequest, SpResultBase> eliminarRubroUseCase, IUseCase<ListarRubroPaginadoRequest, PagedResult<RubroResult>> listarRubroPaginadaUseCase, IUseCase<ListarRubroRequest, List<RubroResult>> listarRubroUseCase, IUseCase<int, RubroResult?> obtenerRubroPorIdUseCase, IPresenterDelivery<PagedResult<RubroResult>, LstItemResponse<RubroResponse>> presenterListPage, IPresenterDelivery<List<RubroResult>, LstItemResponse<RubroResponse>> presenterList, IPresenterDelivery<RubroResult, ItemResponse<RubroResponse>> presenterObtenerId, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt)
        {
            _crearRubroUseCase = crearRubroUseCase;
            _actualizarRubroUseCase = actualizarRubroUseCase;
            _eliminarRubroUseCase = eliminarRubroUseCase;
            _listarRubroPaginadaUseCase = listarRubroPaginadaUseCase;
            _listarRubroUseCase = listarRubroUseCase;
            _obtenerRubroPorIdUseCase = obtenerRubroPorIdUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearRubro([FromBody] CrearRubroRequest request)
        {
            var result = await _crearRubroUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("actualizar")]
        public async Task<IActionResult> ActualizarRubro([FromBody] ActualizarRubroRequest request)
        {
            var result = await _actualizarRubroUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("eliminar")]
        public async Task<IActionResult> EliminarRubro([FromBody] EliminarRubroRequest request)
        {
            var result = await _eliminarRubroUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarRubroPaginado([FromQuery] ListarRubroPaginadoRequest request)
        {
            var result = await _listarRubroPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarRubro([FromQuery] ListarRubroRequest request)
        {
            var result = await _listarRubroUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerRubroPorId(int id)
        {
            var result = await _obtenerRubroPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
        }
    }
}
