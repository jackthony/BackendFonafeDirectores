using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Results;
using Empresa.Presentation.Sector.Responses;
using Shared.ClientV1;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class SectorController : ControllerBase
    {
        private readonly IUseCase<CrearSectorRequest, SpResultBase> _crearSectorUseCase;
        private readonly IUseCase<ActualizarSectorRequest, SpResultBase> _actualizarSectorUseCase;
        private readonly IUseCase<EliminarSectorRequest, SpResultBase> _eliminarSectorUseCase;
        private readonly IUseCase<ListarSectorPaginadoRequest, PagedResult<SectorResult>> _listarSectorPaginadaUseCase;
        private readonly IUseCase<ListarSectorRequest, List<SectorResult>> _listarSectorUseCase;
        private readonly IUseCase<int, SectorResult?> _obtenerSectorPorIdUseCase;
        private readonly IPresenterDelivery<PagedResult<SectorResult>, LstItemResponse<SectorResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<SectorResult>, LstItemResponse<SectorResponse>> _presenterList;
        private readonly IPresenterDelivery<SectorResult, ItemResponse<SectorResponse>> _presenterObtenerId;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;

        public SectorController(IUseCase<CrearSectorRequest, SpResultBase> crearSectorUseCase, IUseCase<ActualizarSectorRequest, SpResultBase> actualizarSectorUseCase, IUseCase<EliminarSectorRequest, SpResultBase> eliminarSectorUseCase, IUseCase<ListarSectorPaginadoRequest, PagedResult<SectorResult>> listarSectorPaginadaUseCase, IUseCase<ListarSectorRequest, List<SectorResult>> listarSectorUseCase, IUseCase<int, SectorResult?> obtenerSectorPorIdUseCase, IPresenterDelivery<PagedResult<SectorResult>, LstItemResponse<SectorResponse>> presenterListPage, IPresenterDelivery<List<SectorResult>, LstItemResponse<SectorResponse>> presenterList, IPresenterDelivery<SectorResult, ItemResponse<SectorResponse>> presenterObtenerId, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt)
        {
            _crearSectorUseCase = crearSectorUseCase;
            _actualizarSectorUseCase = actualizarSectorUseCase;
            _eliminarSectorUseCase = eliminarSectorUseCase;
            _listarSectorPaginadaUseCase = listarSectorPaginadaUseCase;
            _listarSectorUseCase = listarSectorUseCase;
            _obtenerSectorPorIdUseCase = obtenerSectorPorIdUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearSector([FromBody] CrearSectorRequest request)
        {
            var result = await _crearSectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("actualizar")]
        public async Task<IActionResult> ActualizarSector([FromBody] ActualizarSectorRequest request)
        {
            var result = await _actualizarSectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPost("eliminar")]
        public async Task<IActionResult> EliminarSector([FromBody] EliminarSectorRequest request)
        {
            var result = await _eliminarSectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarSectorPaginado([FromQuery] ListarSectorPaginadoRequest request)
        {
            var result = await _listarSectorPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarSector([FromQuery] ListarSectorRequest request)
        {
            var result = await _listarSectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerSectorPorId(int id)
        {
            var result = await _obtenerSectorPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
        }
    }
}
