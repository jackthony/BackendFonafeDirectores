/***********
 * Nombre del archivo:  CargoController.cs
 * Descripción:         Controlador REST para gestionar operaciones CRUD y consultas sobre Cargos.
 *                      Implementa endpoints para crear, actualizar, eliminar, listar (con y sin paginación)
 *                      y obtener Cargos por ID.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial de CRUD para Cargo.
 ***********/

using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Results;
using Empresa.Presentation.Cargo.Responses;
using Shared.ClientV1;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    public class CargoController : ControllerBase
    {
        private readonly IUseCase<CrearCargoRequest, SpResultBase> _crearCargoUseCase;
        private readonly IUseCase<ActualizarCargoRequest, SpResultBase> _actualizarCargoUseCase;
        private readonly IUseCase<EliminarCargoRequest, SpResultBase> _eliminarCargoUseCase;
        private readonly IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoResult>> _listarCargoPaginadaUseCase;
        private readonly IUseCase<ListarCargoRequest, List<CargoResult>> _listarCargoUseCase;
        private readonly IUseCase<int, CargoResult?> _obtenerCargoPorIdUseCase;
        private readonly IPresenterDelivery<PagedResult<CargoResult>, LstItemResponse<CargoResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<CargoResult>, LstItemResponse<CargoResponse>> _presenterList;
        private readonly IPresenterDelivery<CargoResult, ItemResponse<CargoResponse>> _presenterObtenerId;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;

        public CargoController(IUseCase<CrearCargoRequest, SpResultBase> crearCargoUseCase, IUseCase<ActualizarCargoRequest, SpResultBase> actualizarCargoUseCase, IUseCase<EliminarCargoRequest, SpResultBase> eliminarCargoUseCase, IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoResult>> listarCargoPaginadaUseCase, IUseCase<ListarCargoRequest, List<CargoResult>> listarCargoUseCase, IUseCase<int, CargoResult?> obtenerCargoPorIdUseCase, IPresenterDelivery<PagedResult<CargoResult>, LstItemResponse<CargoResponse>> presenterListPage, IPresenterDelivery<List<CargoResult>, LstItemResponse<CargoResponse>> presenterList, IPresenterDelivery<CargoResult, ItemResponse<CargoResponse>> presenterObtenerId, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt)
        {
            _crearCargoUseCase = crearCargoUseCase;
            _actualizarCargoUseCase = actualizarCargoUseCase;
            _eliminarCargoUseCase = eliminarCargoUseCase;
            _listarCargoPaginadaUseCase = listarCargoPaginadaUseCase;
            _listarCargoUseCase = listarCargoUseCase;
            _obtenerCargoPorIdUseCase = obtenerCargoPorIdUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearCargo([FromBody] CrearCargoRequest request)
        {
            var result = await _crearCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("actualizar")]
        public async Task<IActionResult> ActualizarCargo([FromBody] ActualizarCargoRequest request)
        {
            var result = await _actualizarCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("eliminar")]
        public async Task<IActionResult> EliminarCargo([FromBody] EliminarCargoRequest request)
        {
            var result = await _eliminarCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarCargoPaginado([FromQuery] ListarCargoPaginadoRequest request)
        {
            var result = await _listarCargoPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarCargo([FromQuery] ListarCargoRequest request)
        {
            var result = await _listarCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerCargoPorId(int id)
        {
            var result = await _obtenerCargoPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
        }
    }
}
