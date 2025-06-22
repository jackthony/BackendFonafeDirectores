using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Results;

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

        public RubroController(
            IUseCase<CrearRubroRequest, SpResultBase> crearRubroUseCase,
            IUseCase<ActualizarRubroRequest, SpResultBase> actualizarRubroUseCase,
            IUseCase<EliminarRubroRequest, SpResultBase> eliminarRubroUseCase,
            IUseCase<ListarRubroPaginadoRequest, PagedResult<RubroResult>> listarRubroPaginadaUseCase,
            IUseCase<ListarRubroRequest, List<RubroResult>> listarRubroUseCase,
            IUseCase<int, RubroResult?> obtenerRubroPorIdUseCase)
        {
            _crearRubroUseCase = crearRubroUseCase;
            _actualizarRubroUseCase = actualizarRubroUseCase;
            _eliminarRubroUseCase = eliminarRubroUseCase;
            _listarRubroPaginadaUseCase = listarRubroPaginadaUseCase;
            _listarRubroUseCase = listarRubroUseCase;
            _obtenerRubroPorIdUseCase = obtenerRubroPorIdUseCase;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearRubro([FromBody] CrearRubroRequest request)
        {
            var result = await _crearRubroUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarRubro([FromBody] ActualizarRubroRequest request)
        {
            var result = await _actualizarRubroUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarRubro([FromBody] EliminarRubroRequest request)
        {
            var result = await _eliminarRubroUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarRubroPaginado([FromQuery] ListarRubroPaginadoRequest request)
        {
            var result = await _listarRubroPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarRubro([FromQuery] ListarRubroRequest request)
        {
            var result = await _listarRubroUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerRubroPorId(int id)
        {
            var result = await _obtenerRubroPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return NotFound();
            return Ok(result);
        }
    }
}
