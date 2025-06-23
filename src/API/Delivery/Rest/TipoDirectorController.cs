using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Responses;
using Shared.ClientV1;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class TipoDirectorController : ControllerBase
    {
        private readonly IUseCase<CrearTipoDirectorRequest, SpResultBase> _crearTipoDirectorUseCase;
        private readonly IUseCase<ActualizarTipoDirectorRequest, SpResultBase> _actualizarTipoDirectorUseCase;
        private readonly IUseCase<EliminarTipoDirectorRequest, SpResultBase> _eliminarTipoDirectorUseCase;
        private readonly IUseCase<ListarTipoDirectorPaginadoRequest, PagedResult<TipoDirectorResult>> _listarTipoDirectorPaginadaUseCase;
        private readonly IUseCase<ListarTipoDirectorRequest, List<TipoDirectorResult>> _listarTipoDirectorUseCase;
        private readonly IUseCase<int, TipoDirectorResult?> _obtenerTipoDirectorPorIdUseCase;
        private readonly IPresenterDelivery<PagedResult<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>> _presenterList;
        private readonly IPresenterDelivery<TipoDirectorResult, ItemResponse<TipoDirectorResponse>> _presenterObtenerId;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;

        public TipoDirectorController(IUseCase<CrearTipoDirectorRequest, SpResultBase> crearTipoDirectorUseCase, IUseCase<ActualizarTipoDirectorRequest, SpResultBase> actualizarTipoDirectorUseCase, IUseCase<EliminarTipoDirectorRequest, SpResultBase> eliminarTipoDirectorUseCase, IUseCase<ListarTipoDirectorPaginadoRequest, PagedResult<TipoDirectorResult>> listarTipoDirectorPaginadaUseCase, IUseCase<ListarTipoDirectorRequest, List<TipoDirectorResult>> listarTipoDirectorUseCase, IUseCase<int, TipoDirectorResult?> obtenerTipoDirectorPorIdUseCase, IPresenterDelivery<PagedResult<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>> presenterListPage, IPresenterDelivery<List<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>> presenterList, IPresenterDelivery<TipoDirectorResult, ItemResponse<TipoDirectorResponse>> presenterObtenerId, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt)
        {
            _crearTipoDirectorUseCase = crearTipoDirectorUseCase;
            _actualizarTipoDirectorUseCase = actualizarTipoDirectorUseCase;
            _eliminarTipoDirectorUseCase = eliminarTipoDirectorUseCase;
            _listarTipoDirectorPaginadaUseCase = listarTipoDirectorPaginadaUseCase;
            _listarTipoDirectorUseCase = listarTipoDirectorUseCase;
            _obtenerTipoDirectorPorIdUseCase = obtenerTipoDirectorPorIdUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearTipoDirector([FromBody] CrearTipoDirectorRequest request)
        {
            var result = await _crearTipoDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarTipoDirector([FromBody] ActualizarTipoDirectorRequest request)
        {
            var result = await _actualizarTipoDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarTipoDirector([FromBody] EliminarTipoDirectorRequest request)
        {
            var result = await _eliminarTipoDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarTipoDirectorPaginado([FromQuery] ListarTipoDirectorPaginadoRequest request)
        {
            var result = await _listarTipoDirectorPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarTipoDirector([FromQuery] ListarTipoDirectorRequest request)
        {
            var result = await _listarTipoDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerTipoDirectorPorId(int id)
        {
            var result = await _obtenerTipoDirectorPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
        }
    }
}
