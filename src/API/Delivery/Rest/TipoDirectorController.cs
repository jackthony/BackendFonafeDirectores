using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Results;

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

        public TipoDirectorController(
            IUseCase<CrearTipoDirectorRequest, SpResultBase> crearTipoDirectorUseCase,
            IUseCase<ActualizarTipoDirectorRequest, SpResultBase> actualizarTipoDirectorUseCase,
            IUseCase<EliminarTipoDirectorRequest, SpResultBase> eliminarTipoDirectorUseCase,
            IUseCase<ListarTipoDirectorPaginadoRequest, PagedResult<TipoDirectorResult>> listarTipoDirectorPaginadaUseCase,
            IUseCase<ListarTipoDirectorRequest, List<TipoDirectorResult>> listarTipoDirectorUseCase,
            IUseCase<int, TipoDirectorResult?> obtenerTipoDirectorPorIdUseCase)
        {
            _crearTipoDirectorUseCase = crearTipoDirectorUseCase;
            _actualizarTipoDirectorUseCase = actualizarTipoDirectorUseCase;
            _eliminarTipoDirectorUseCase = eliminarTipoDirectorUseCase;
            _listarTipoDirectorPaginadaUseCase = listarTipoDirectorPaginadaUseCase;
            _listarTipoDirectorUseCase = listarTipoDirectorUseCase;
            _obtenerTipoDirectorPorIdUseCase = obtenerTipoDirectorPorIdUseCase;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearTipoDirector([FromBody] CrearTipoDirectorRequest request)
        {
            var result = await _crearTipoDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarTipoDirector([FromBody] ActualizarTipoDirectorRequest request)
        {
            var result = await _actualizarTipoDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarTipoDirector([FromBody] EliminarTipoDirectorRequest request)
        {
            var result = await _eliminarTipoDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarTipoDirectorPaginado([FromQuery] ListarTipoDirectorPaginadoRequest request)
        {
            var result = await _listarTipoDirectorPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarTipoDirector([FromQuery] ListarTipoDirectorRequest request)
        {
            var result = await _listarTipoDirectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerTipoDirectorPorId(int id)
        {
            var result = await _obtenerTipoDirectorPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }
    }
}
