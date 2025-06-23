using Api.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Results;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class EmpresaController : ControllerBase
    {
        private readonly IUseCase<CrearEmpresaRequest, SpResultBase> _crearEmpresaUseCase;
        private readonly IUseCase<ActualizarEmpresaRequest, SpResultBase> _actualizarEmpresaUseCase;
        private readonly IUseCase<EliminarEmpresaRequest, SpResultBase> _eliminarEmpresaUseCase;
        private readonly IUseCase<ListarEmpresaPaginadoRequest, PagedResult<EmpresaResult>> _listarEmpresaPaginadaUseCase;
        private readonly IUseCase<ListarEmpresaRequest, List<EmpresaResult>> _listarEmpresaUseCase;
        private readonly IUseCase<int, EmpresaResult?> _obtenerEmpresaPorIdUseCase;

        public EmpresaController(
            IUseCase<CrearEmpresaRequest, SpResultBase> crearEmpresaUseCase,
            IUseCase<ActualizarEmpresaRequest, SpResultBase> actualizarEmpresaUseCase,
            IUseCase<EliminarEmpresaRequest, SpResultBase> eliminarEmpresaUseCase,
            IUseCase<ListarEmpresaPaginadoRequest, PagedResult<EmpresaResult>> listarEmpresaPaginadaUseCase,
            IUseCase<ListarEmpresaRequest, List<EmpresaResult>> listarEmpresaUseCase,
            IUseCase<int, EmpresaResult?> obtenerEmpresaPorIdUseCase)
        {
            _crearEmpresaUseCase = crearEmpresaUseCase;
            _actualizarEmpresaUseCase = actualizarEmpresaUseCase;
            _eliminarEmpresaUseCase = eliminarEmpresaUseCase;
            _listarEmpresaPaginadaUseCase = listarEmpresaPaginadaUseCase;
            _listarEmpresaUseCase = listarEmpresaUseCase;
            _obtenerEmpresaPorIdUseCase = obtenerEmpresaPorIdUseCase;
        }

        [HttpPost("crear")]
        public async Task<IActionResult> CrearEmpresa([FromBody] CrearEmpresaRequest request)
        {
            var result = await _crearEmpresaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpPut("actualizar")]
        public async Task<IActionResult> ActualizarEmpresa([FromBody] ActualizarEmpresaRequest request)
        {
            var result = await _actualizarEmpresaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpDelete("eliminar")]
        public async Task<IActionResult> EliminarEmpresa([FromBody] EliminarEmpresaRequest request)
        {
            var result = await _eliminarEmpresaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar-paginado")]
        public async Task<IActionResult> ListarEmpresaPaginado([FromQuery] ListarEmpresaPaginadoRequest request)
        {
            var result = await _listarEmpresaPaginadaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarEmpresa([FromQuery] ListarEmpresaRequest request)
        {
            var result = await _listarEmpresaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerEmpresaPorId(int id)
        {
            var result = await _obtenerEmpresaPorIdUseCase.ExecuteAsync(id);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }
    }
}
