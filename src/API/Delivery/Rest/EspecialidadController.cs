using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Especialidad.Dtos;
using Empresa.Domain.Especialidad.Results;

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

        public EspecialidadController(
            IUseCase<CrearEspecialidadRequest, SpResultBase> crearEspecialidadUseCase,
            IUseCase<ActualizarEspecialidadRequest, SpResultBase> actualizarEspecialidadUseCase,
            IUseCase<EliminarEspecialidadRequest, SpResultBase> eliminarEspecialidadUseCase,
            IUseCase<ListarEspecialidadPaginadoRequest, PagedResult<EspecialidadResult>> listarEspecialidadPaginadaUseCase,
            IUseCase<ListarEspecialidadRequest, List<EspecialidadResult>> listarEspecialidadUseCase,
            IUseCase<int, EspecialidadResult?> obtenerEspecialidadPorIdUseCase)
        {
            _crearEspecialidadUseCase = crearEspecialidadUseCase;
            _actualizarEspecialidadUseCase = actualizarEspecialidadUseCase;
            _eliminarEspecialidadUseCase = eliminarEspecialidadUseCase;
            _listarEspecialidadPaginadaUseCase = listarEspecialidadPaginadaUseCase;
            _listarEspecialidadUseCase = listarEspecialidadUseCase;
            _obtenerEspecialidadPorIdUseCase = obtenerEspecialidadPorIdUseCase;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearEspecialidad([FromBody] CrearEspecialidadRequest request)
        {
            var result = await _crearEspecialidadUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarEspecialidad([FromBody] ActualizarEspecialidadRequest request)
        {
            var result = await _actualizarEspecialidadUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarEspecialidad([FromBody] EliminarEspecialidadRequest request)
        {
            var result = await _eliminarEspecialidadUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarEspecialidadPaginado([FromQuery] ListarEspecialidadPaginadoRequest request)
        {
            var result = await _listarEspecialidadPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarEspecialidad([FromQuery] ListarEspecialidadRequest request)
        {
            var result = await _listarEspecialidadUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerEspecialidadPorId(int id)
        {
            var result = await _obtenerEspecialidadPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }
    }
}
