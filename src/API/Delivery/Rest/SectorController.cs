using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Results;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SectorController : ControllerBase
    {
        private readonly IUseCase<CrearSectorRequest, SpResultBase> _crearSectorUseCase;
        private readonly IUseCase<ActualizarSectorRequest, SpResultBase> _actualizarSectorUseCase;
        private readonly IUseCase<EliminarSectorRequest, SpResultBase> _eliminarSectorUseCase;
        private readonly IUseCase<ListarSectorPaginadoRequest, PagedResult<SectorResult>> _listarSectorPaginadaUseCase;
        private readonly IUseCase<ListarSectorRequest, List<SectorResult>> _listarSectorUseCase;
        private readonly IUseCase<int, SectorResult?> _obtenerSectorPorIdUseCase;

        public SectorController(
            IUseCase<CrearSectorRequest, SpResultBase> crearSectorUseCase,
            IUseCase<ActualizarSectorRequest, SpResultBase> actualizarSectorUseCase,
            IUseCase<EliminarSectorRequest, SpResultBase> eliminarSectorUseCase,
            IUseCase<ListarSectorPaginadoRequest, PagedResult<SectorResult>> listarSectorPaginadaUseCase,
            IUseCase<ListarSectorRequest, List<SectorResult>> listarSectorUseCase,
            IUseCase<int, SectorResult?> obtenerSectorPorIdUseCase)
        {
            _crearSectorUseCase = crearSectorUseCase;
            _actualizarSectorUseCase = actualizarSectorUseCase;
            _eliminarSectorUseCase = eliminarSectorUseCase;
            _listarSectorPaginadaUseCase = listarSectorPaginadaUseCase;
            _listarSectorUseCase = listarSectorUseCase;
            _obtenerSectorPorIdUseCase = obtenerSectorPorIdUseCase;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearSector([FromBody] CrearSectorRequest request)
        {
            var result = await _crearSectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarSector([FromBody] ActualizarSectorRequest request)
        {
            var result = await _actualizarSectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarSector([FromBody] EliminarSectorRequest request)
        {
            var result = await _eliminarSectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarSectorPaginado([FromQuery] ListarSectorPaginadoRequest request)
        {
            var result = await _listarSectorPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarSector([FromQuery] ListarSectorRequest request)
        {
            var result = await _listarSectorUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerSectorPorId(int id)
        {
            var result = await _obtenerSectorPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return NotFound();
            return Ok(result);
        }
    }
}
