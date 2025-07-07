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
        private readonly IUseCase<ObtenerAuditoriaUsuariosRequest, Stream> _exportarAuditoriaUseCase;
        private readonly IUseCase<ObtenerUsuariosPorTipoUsuarioRequest, Stream> _exportarPorTipoUsuarioUseCase;

        public AuditoriaUsuariosController(
            IUseCase<ObtenerAuditoriaUsuariosRequest, Stream> exportarAuditoriaUseCase,
            IUseCase<ObtenerUsuariosPorTipoUsuarioRequest, Stream> exportarPorTipoUsuarioUseCase)
        {
            _exportarAuditoriaUseCase = exportarAuditoriaUseCase;
            _exportarPorTipoUsuarioUseCase = exportarPorTipoUsuarioUseCase;
        }

        [HttpPost("exportar-auditoria-estado")]
        public async Task<IActionResult> ExportarAuditoriaPorEstado([FromBody] ObtenerAuditoriaUsuariosRequest request)
        {
            var result = await _exportarAuditoriaUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            var stream = result.AsT1;
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            var fileName = $"auditoria-estado-usuarios-{DateTime.Now:yyyyMMddHHmmss}.xlsx";

            return File(stream, contentType, fileName);
        }

        [HttpPost("exportar-por-rol")]
        public async Task<IActionResult> ExportarUsuariosPorRol([FromBody] ObtenerUsuariosPorTipoUsuarioRequest request)
        {
            var result = await _exportarPorTipoUsuarioUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            var stream = result.AsT1;
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            var fileName = $"usuarios-por-rol-{DateTime.Now:yyyyMMddHHmmss}.xlsx";

            return File(stream, contentType, fileName);
        }
    }
}
