using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Responses;
using Shared.ClientV1;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class EspecialidadController : ControllerBase
    {
        private readonly IUseCase<CrearEspecialidadRequest, SpResultBase> _crearEspecialidadUseCase;
        private readonly IUseCase<ActualizarEspecialidadRequest, SpResultBase> _actualizarEspecialidadUseCase;
        private readonly IUseCase<EliminarEspecialidadRequest, SpResultBase> _eliminarEspecialidadUseCase;
        private readonly IUseCase<ListarEspecialidadPaginadoRequest, PagedResult<EspecialidadResult>> _listarEspecialidadPaginadaUseCase;
        private readonly IUseCase<ListarEspecialidadRequest, List<EspecialidadResult>> _listarEspecialidadUseCase;
        private readonly IUseCase<int, EspecialidadResult?> _obtenerEspecialidadPorIdUseCase;
        private readonly IPresenterDelivery<PagedResult<EspecialidadResult>, LstItemResponse<EspecialidadResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<EspecialidadResult>, LstItemResponse<EspecialidadResponse>> _presenterList;
        private readonly IPresenterDelivery<EspecialidadResult, ItemResponse<EspecialidadResponse>> _presenterObtenerId;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;

        public EspecialidadController(IUseCase<CrearEspecialidadRequest, SpResultBase> crearEspecialidadUseCase, IUseCase<ActualizarEspecialidadRequest, SpResultBase> actualizarEspecialidadUseCase, IUseCase<EliminarEspecialidadRequest, SpResultBase> eliminarEspecialidadUseCase, IUseCase<ListarEspecialidadPaginadoRequest, PagedResult<EspecialidadResult>> listarEspecialidadPaginadaUseCase, IUseCase<ListarEspecialidadRequest, List<EspecialidadResult>> listarEspecialidadUseCase, IUseCase<int, EspecialidadResult?> obtenerEspecialidadPorIdUseCase, IPresenterDelivery<PagedResult<EspecialidadResult>, LstItemResponse<EspecialidadResponse>> presenterListPage, IPresenterDelivery<List<EspecialidadResult>, LstItemResponse<EspecialidadResponse>> presenterList, IPresenterDelivery<EspecialidadResult, ItemResponse<EspecialidadResponse>> presenterObtenerId, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt)
        {
            _crearEspecialidadUseCase = crearEspecialidadUseCase;
            _actualizarEspecialidadUseCase = actualizarEspecialidadUseCase;
            _eliminarEspecialidadUseCase = eliminarEspecialidadUseCase;
            _listarEspecialidadPaginadaUseCase = listarEspecialidadPaginadaUseCase;
            _listarEspecialidadUseCase = listarEspecialidadUseCase;
            _obtenerEspecialidadPorIdUseCase = obtenerEspecialidadPorIdUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearEspecialidad([FromBody] CrearEspecialidadRequest request)
        {
            var result = await _crearEspecialidadUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarEspecialidad([FromBody] ActualizarEspecialidadRequest request)
        {
            var result = await _actualizarEspecialidadUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarEspecialidad([FromBody] EliminarEspecialidadRequest request)
        {
            var result = await _eliminarEspecialidadUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarEspecialidadPaginado([FromQuery] ListarEspecialidadPaginadoRequest request)
        {
            var result = await _listarEspecialidadPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarEspecialidad([FromQuery] ListarEspecialidadRequest request)
        {
            var result = await _listarEspecialidadUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerEspecialidadPorId(int id)
        {
            var result = await _obtenerEspecialidadPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
        }
    }
}
