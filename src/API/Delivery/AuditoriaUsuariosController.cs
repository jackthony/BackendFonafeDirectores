using Api.Helpers;
using Microsoft.AspNetCore.Mvc;
using Shared.Kernel.Interfaces;
using Usuario.Domain.SEG_Log.Parameters;

namespace Api.Delivery.Rest
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize]
    public class AuditoriaUsuariosController : ControllerBase
    {
        private readonly IUseCase<ObtenerAuditoriaUsuariosRequest, Stream> _exportarUseCase;

        public AuditoriaUsuariosController(IUseCase<ObtenerAuditoriaUsuariosRequest, Stream> exportarUseCase)
        {
            _exportarUseCase = exportarUseCase;
        }

        [HttpPost("exportar")]
        public async Task<IActionResult> Exportar([FromBody] ObtenerAuditoriaUsuariosRequest request)
        {
            var result = await _exportarUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            var stream = result.AsT1;

            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            var fileName = $"auditoria-usuarios-{DateTime.Now:yyyyMMddHHmmss}.xlsx";

            return File(stream, contentType, fileName);
        }
    }
}
