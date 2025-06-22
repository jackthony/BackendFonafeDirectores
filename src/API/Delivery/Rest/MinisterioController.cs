using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Results;

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

        public MinisterioController(
            IUseCase<CrearMinisterioRequest, SpResultBase> crearMinisterioUseCase,
            IUseCase<ActualizarMinisterioRequest, SpResultBase> actualizarMinisterioUseCase,
            IUseCase<EliminarMinisterioRequest, SpResultBase> eliminarMinisterioUseCase,
            IUseCase<ListarMinisterioPaginadoRequest, PagedResult<MinisterioResult>> listarMinisterioPaginadaUseCase,
            IUseCase<ListarMinisterioRequest, List<MinisterioResult>> listarMinisterioUseCase,
            IUseCase<int, MinisterioResult?> obtenerMinisterioPorIdUseCase)
        {
            _crearMinisterioUseCase = crearMinisterioUseCase;
            _actualizarMinisterioUseCase = actualizarMinisterioUseCase;
            _eliminarMinisterioUseCase = eliminarMinisterioUseCase;
            _listarMinisterioPaginadaUseCase = listarMinisterioPaginadaUseCase;
            _listarMinisterioUseCase = listarMinisterioUseCase;
            _obtenerMinisterioPorIdUseCase = obtenerMinisterioPorIdUseCase;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearMinisterio([FromBody] CrearMinisterioRequest request)
        {
            var result = await _crearMinisterioUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarMinisterio([FromBody] ActualizarMinisterioRequest request)
        {
            var result = await _actualizarMinisterioUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarMinisterio([FromBody] EliminarMinisterioRequest request)
        {
            var result = await _eliminarMinisterioUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarMinisterioPaginado([FromQuery] ListarMinisterioPaginadoRequest request)
        {
            var result = await _listarMinisterioPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarMinisterio([FromQuery] ListarMinisterioRequest request)
        {
            var result = await _listarMinisterioUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerMinisterioPorId(int id)
        {
            var result = await _obtenerMinisterioPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return NotFound();
            return Ok(result);
        }
    }
}
