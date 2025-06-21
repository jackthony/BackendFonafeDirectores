using Api.Helpers;
using Empresa.Application.Dtos;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly IUseCase<ListarEmpresaRequest, List<EmpresaDto>> _listarEmpresaUseCase;

        public EmpresaController(IUseCase<ListarEmpresaRequest, List<EmpresaDto>> listarEmpresaUseCase)
        {
            _listarEmpresaUseCase = listarEmpresaUseCase;
        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarEmpresas([FromBody] ListarEmpresaRequest request)
        {
            var result = await _listarEmpresaUseCase.ExecuteAsync(request);
            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);
            return Ok(result.AsT1);
        }
    }
}
