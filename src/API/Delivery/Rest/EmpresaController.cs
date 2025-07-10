/***********
 * Nombre del archivo:  EmpresaController.cs
 * Descripción:         Controlador REST para gestionar operaciones CRUD y consultas sobre Empresas.
 *                      Implementa endpoints para crear, actualizar, eliminar, listar (con y sin paginación)
 *                      y obtener Empresas por ID.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial de CRUD para Empresa.
 ***********/

using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Results;
using Empresa.Presentation.Empresa.Responses;
using Shared.ClientV1;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class EmpresaController : ControllerBase
    {
        private readonly IUseCase<CrearEmpresaRequest, SpResultBase> _crearEmpresaUseCase;
        private readonly IUseCase<ActualizarEmpresaRequest, SpResultBase> _actualizarEmpresaUseCase;
        private readonly IUseCase<EliminarEmpresaRequest, SpResultBase> _eliminarEmpresaUseCase;
        private readonly IUseCase<ListarEmpresaPaginadoRequest, PagedResult<EmpresaResult>> _listarEmpresaPaginadaUseCase;
        private readonly IUseCase<ListarEmpresaRequest, List<EmpresaResult>> _listarEmpresaUseCase;
        private readonly IUseCase<int, EmpresaResult?> _obtenerEmpresaPorIdUseCase;
        private readonly IPresenterDelivery<PagedResult<EmpresaResult>, LstItemResponse<EmpresaResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<EmpresaResult>, LstItemResponse<EmpresaResponse>> _presenterList;
        private readonly IPresenterDelivery<EmpresaResult, ItemResponse<EmpresaResponse>> _presenterObtenerId;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;

        public EmpresaController(IUseCase<CrearEmpresaRequest, SpResultBase> crearEmpresaUseCase, IUseCase<ActualizarEmpresaRequest, SpResultBase> actualizarEmpresaUseCase, IUseCase<EliminarEmpresaRequest, SpResultBase> eliminarEmpresaUseCase, IUseCase<ListarEmpresaPaginadoRequest, PagedResult<EmpresaResult>> listarEmpresaPaginadaUseCase, IUseCase<ListarEmpresaRequest, List<EmpresaResult>> listarEmpresaUseCase, IUseCase<int, EmpresaResult?> obtenerEmpresaPorIdUseCase, IPresenterDelivery<PagedResult<EmpresaResult>, LstItemResponse<EmpresaResponse>> presenterListPage, IPresenterDelivery<List<EmpresaResult>, LstItemResponse<EmpresaResponse>> presenterList, IPresenterDelivery<EmpresaResult, ItemResponse<EmpresaResponse>> presenterObtenerId, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt)
        {
            _crearEmpresaUseCase = crearEmpresaUseCase;
            _actualizarEmpresaUseCase = actualizarEmpresaUseCase;
            _eliminarEmpresaUseCase = eliminarEmpresaUseCase;
            _listarEmpresaPaginadaUseCase = listarEmpresaPaginadaUseCase;
            _listarEmpresaUseCase = listarEmpresaUseCase;
            _obtenerEmpresaPorIdUseCase = obtenerEmpresaPorIdUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearEmpresa([FromBody] CrearEmpresaRequest request)
        {
            var result = await _crearEmpresaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("actualizar")]
        public async Task<IActionResult> ActualizarEmpresa([FromBody] ActualizarEmpresaRequest request)
        {
            var result = await _actualizarEmpresaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("eliminar")]
        public async Task<IActionResult> EliminarEmpresa([FromBody] EliminarEmpresaRequest request)
        {
            var result = await _eliminarEmpresaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarEmpresaPaginado([FromQuery] ListarEmpresaPaginadoRequest request)
        {
            var result = await _listarEmpresaPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarEmpresa([FromQuery] ListarEmpresaRequest request)
        {
            var result = await _listarEmpresaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerEmpresaPorId(int id)
        {
            var result = await _obtenerEmpresaPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
        }
    }
}
