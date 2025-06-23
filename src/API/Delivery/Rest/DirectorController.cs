using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Results;
using Empresa.Presentation.Director.Responses;
using Shared.ClientV1;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class DirectorController : ControllerBase
    {
        private readonly IUseCase<CrearDirectorRequest, SpResultBase> _crearDirectorUseCase;
        private readonly IUseCase<ActualizarDirectorRequest, SpResultBase> _actualizarDirectorUseCase;
        private readonly IUseCase<EliminarDirectorRequest, SpResultBase> _eliminarDirectorUseCase;
        private readonly IUseCase<ListarDirectorPaginadoRequest, PagedResult<DirectorResult>> _listarDirectorPaginadaUseCase;
        private readonly IUseCase<ListarDirectorRequest, List<DirectorResult>> _listarDirectorUseCase;
        private readonly IUseCase<int, DirectorResult?> _obtenerDirectorPorIdUseCase;
        private readonly IPresenterDelivery<PagedResult<DirectorResult>, LstItemResponse<DirectorResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<DirectorResult>, LstItemResponse<DirectorResponse>> _presenterList;
        private readonly IPresenterDelivery<DirectorResult, ItemResponse<DirectorResponse>> _presenterObtenerId;

        public DirectorController(
            IUseCase<CrearDirectorRequest, SpResultBase> crearDirectorUseCase,
            IUseCase<ActualizarDirectorRequest, SpResultBase> actualizarDirectorUseCase,
            IUseCase<EliminarDirectorRequest, SpResultBase> eliminarDirectorUseCase,
            IUseCase<ListarDirectorPaginadoRequest, PagedResult<DirectorResult>> listarDirectorPaginadaUseCase,
            IUseCase<ListarDirectorRequest, List<DirectorResult>> listarDirectorUseCase,
            IUseCase<int, DirectorResult?> obtenerDirectorPorIdUseCase,
            IPresenterDelivery<PagedResult<DirectorResult>, LstItemResponse<DirectorResponse>> presenterListPage,
            IPresenterDelivery<List<DirectorResult>, LstItemResponse<DirectorResponse>> presenterList,
            IPresenterDelivery<DirectorResult, ItemResponse<DirectorResponse>> presenterObtenerId)
        {
            _crearDirectorUseCase = crearDirectorUseCase;
            _actualizarDirectorUseCase = actualizarDirectorUseCase;
            _eliminarDirectorUseCase = eliminarDirectorUseCase;
            _listarDirectorPaginadaUseCase = listarDirectorPaginadaUseCase;
            _listarDirectorUseCase = listarDirectorUseCase;
            _obtenerDirectorPorIdUseCase = obtenerDirectorPorIdUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearDirector([FromBody] CrearDirectorRequest request)
        {
            var result = await _crearDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarDirector([FromBody] ActualizarDirectorRequest request)
        {
            var result = await _actualizarDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarDirector([FromBody] EliminarDirectorRequest request)
        {
            var result = await _eliminarDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarDirectorPaginado([FromQuery] ListarDirectorPaginadoRequest request)
        {
            var result = await _listarDirectorPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarDirector([FromQuery] ListarDirectorRequest request)
        {
            var result = await _listarDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerDirectorPorId(int id)
        {
            var result = await _obtenerDirectorPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
        }
    }
}
