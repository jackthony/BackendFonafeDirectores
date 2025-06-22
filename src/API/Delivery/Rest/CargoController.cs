using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Results;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CargoController : ControllerBase
    {
        private readonly IUseCase<CrearCargoRequest, SpResultBase> _crearCargoUseCase;
        private readonly IUseCase<ActualizarCargoRequest, SpResultBase> _actualizarCargoUseCase;
        private readonly IUseCase<EliminarCargoRequest, SpResultBase> _eliminarCargoUseCase;
        private readonly IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoResult>> _listarCargoPaginadaUseCase;
        private readonly IUseCase<ListarCargoRequest, List<CargoResult>> _listarCargoUseCase;
        private readonly IUseCase<int, CargoResult?> _obtenerCargoPorIdUseCase;

        public CargoController(
            IUseCase<CrearCargoRequest, SpResultBase> crearCargoUseCase,
            IUseCase<ActualizarCargoRequest, SpResultBase> actualizarCargoUseCase,
            IUseCase<EliminarCargoRequest, SpResultBase> eliminarCargoUseCase,
            IUseCase<ListarCargoPaginadoRequest, PagedResult<CargoResult>> listarCargoPaginadaUseCase,
            IUseCase<ListarCargoRequest, List<CargoResult>> listarCargoUseCase,
            IUseCase<int, CargoResult?> obtenerCargoPorIdUseCase)
        {
            _crearCargoUseCase = crearCargoUseCase;
            _actualizarCargoUseCase = actualizarCargoUseCase;
            _eliminarCargoUseCase = eliminarCargoUseCase;
            _listarCargoPaginadaUseCase = listarCargoPaginadaUseCase;
            _listarCargoUseCase = listarCargoUseCase;
            _obtenerCargoPorIdUseCase = obtenerCargoPorIdUseCase;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearCargo([FromBody] CrearCargoRequest request)
        {
            var result = await _crearCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarCargo([FromBody] ActualizarCargoRequest request)
        {
            var result = await _actualizarCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarCargo([FromBody] EliminarCargoRequest request)
        {
            var result = await _eliminarCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarCargoPaginado([FromQuery] ListarCargoPaginadoRequest request)
        {
            var result = await _listarCargoPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarCargo([FromQuery] ListarCargoRequest request)
        {
            var result = await _listarCargoUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerCargoPorId(int id)
        {
            var result = await _obtenerCargoPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return NotFound();
            return Ok(result);
        }
    }
}
