using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Results;
using Empresa.Presentation.Ministerio.Responses;
using Shared.ClientV1;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class MinisterioController : ControllerBase
    {
        private readonly IUseCase<CrearMinisterioRequest, SpResultBase> _crearMinisterioUseCase;
        private readonly IUseCase<ActualizarMinisterioRequest, SpResultBase> _actualizarMinisterioUseCase;
        private readonly IUseCase<EliminarMinisterioRequest, SpResultBase> _eliminarMinisterioUseCase;
        private readonly IUseCase<ListarMinisterioPaginadoRequest, PagedResult<MinisterioResult>> _listarMinisterioPaginadaUseCase;
        private readonly IUseCase<ListarMinisterioRequest, List<MinisterioResult>> _listarMinisterioUseCase;
        private readonly IUseCase<int, MinisterioResult?> _obtenerMinisterioPorIdUseCase;
        private readonly IPresenterDelivery<PagedResult<MinisterioResult>, LstItemResponse<MinisterioResponse>> _presenterListPage;
        private readonly IPresenterDelivery<List<MinisterioResult>, LstItemResponse<MinisterioResponse>> _presenterList;
        private readonly IPresenterDelivery<MinisterioResult, ItemResponse<MinisterioResponse>> _presenterObtenerId;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<bool>> _presenterBool;
        private readonly IPresenterDelivery<SpResultBase, ItemResponse<int>> _presenterInt;

        public MinisterioController(IUseCase<CrearMinisterioRequest, SpResultBase> crearMinisterioUseCase, IUseCase<ActualizarMinisterioRequest, SpResultBase> actualizarMinisterioUseCase, IUseCase<EliminarMinisterioRequest, SpResultBase> eliminarMinisterioUseCase, IUseCase<ListarMinisterioPaginadoRequest, PagedResult<MinisterioResult>> listarMinisterioPaginadaUseCase, IUseCase<ListarMinisterioRequest, List<MinisterioResult>> listarMinisterioUseCase, IUseCase<int, MinisterioResult?> obtenerMinisterioPorIdUseCase, IPresenterDelivery<PagedResult<MinisterioResult>, LstItemResponse<MinisterioResponse>> presenterListPage, IPresenterDelivery<List<MinisterioResult>, LstItemResponse<MinisterioResponse>> presenterList, IPresenterDelivery<MinisterioResult, ItemResponse<MinisterioResponse>> presenterObtenerId, IPresenterDelivery<SpResultBase, ItemResponse<bool>> presenterBool, IPresenterDelivery<SpResultBase, ItemResponse<int>> presenterInt)
        {
            _crearMinisterioUseCase = crearMinisterioUseCase;
            _actualizarMinisterioUseCase = actualizarMinisterioUseCase;
            _eliminarMinisterioUseCase = eliminarMinisterioUseCase;
            _listarMinisterioPaginadaUseCase = listarMinisterioPaginadaUseCase;
            _listarMinisterioUseCase = listarMinisterioUseCase;
            _obtenerMinisterioPorIdUseCase = obtenerMinisterioPorIdUseCase;
            _presenterListPage = presenterListPage;
            _presenterList = presenterList;
            _presenterObtenerId = presenterObtenerId;
            _presenterBool = presenterBool;
            _presenterInt = presenterInt;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearMinisterio([FromBody] CrearMinisterioRequest request)
        {
            var result = await _crearMinisterioUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterInt.Present(result.AsT1);
            return Ok(response);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarMinisterio([FromBody] ActualizarMinisterioRequest request)
        {
            var result = await _actualizarMinisterioUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarMinisterio([FromBody] EliminarMinisterioRequest request)
        {
            var result = await _eliminarMinisterioUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterBool.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarMinisterioPaginado([FromQuery] ListarMinisterioPaginadoRequest request)
        {
            var result = await _listarMinisterioPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterListPage.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarMinisterio([FromQuery] ListarMinisterioRequest request)
        {
            var result = await _listarMinisterioUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            var response = _presenterList.Present(result.AsT1);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerMinisterioPorId(int id)
        {
            var result = await _obtenerMinisterioPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            if (result.AsT1 == null)
                return NotFound();
            var response = _presenterObtenerId.Present(result.AsT1);
            return Ok(response);
        }
    }
}
