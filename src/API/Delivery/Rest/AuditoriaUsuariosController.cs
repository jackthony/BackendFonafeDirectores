/***********
 * Nombre del archivo:  AuditoriaUsuariosController.cs
 * Descripción:         Controlador REST para la exportación de reportes de auditoría y logs relacionados a usuarios.
 *                      Proporciona endpoints para exportar auditoría por estado, usuarios por rol,
 *                      log del sistema y log de trazabilidad en formato Excel.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial de exportación de reportes de auditoría y logs.
 ***********/

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
        private readonly IUseCase<ObtenerLogSistemaPorFechasRequest, Stream> _exportarLogSistemaUseCase;
        private readonly IUseCase<ObtenerLogTrazabilidadRequest, Stream> _exportarLogTrazabilidadUseCase;

        public AuditoriaUsuariosController(
            IUseCase<ObtenerAuditoriaUsuariosRequest, Stream> exportarAuditoriaUseCase,
            IUseCase<ObtenerUsuariosPorTipoUsuarioRequest, Stream> exportarPorTipoUsuarioUseCase,
            IUseCase<ObtenerLogSistemaPorFechasRequest, Stream> exportarLogSistemaUseCase,
            IUseCase<ObtenerLogTrazabilidadRequest, Stream> exportarLogTrazabilidadUseCase)
        {
            _exportarAuditoriaUseCase = exportarAuditoriaUseCase;
            _exportarPorTipoUsuarioUseCase = exportarPorTipoUsuarioUseCase;
            _exportarLogSistemaUseCase = exportarLogSistemaUseCase;
            _exportarLogTrazabilidadUseCase = exportarLogTrazabilidadUseCase;
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

        [HttpPost("exportar-log-sistema")]
        public async Task<IActionResult> ExportarLogSistema([FromBody] ObtenerLogSistemaPorFechasRequest request)
        {
            var result = await _exportarLogSistemaUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            var stream = result.AsT1;
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            var fileName = $"log-sistema-{DateTime.Now:yyyyMMddHHmmss}.xlsx";

            return File(stream, contentType, fileName);
        }

        [HttpPost("exportar-log-trazabilidad")]
        public async Task<IActionResult> ExportarLogTrazabilidad([FromBody] ObtenerLogTrazabilidadRequest request)
        {
            var result = await _exportarLogTrazabilidadUseCase.ExecuteAsync(request);

            if (result.IsT0)
                return ErrorResultMapper.MapError(result.AsT0);

            var stream = result.AsT1;
            var contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            var fileName = $"log-trazabilidad-{DateTime.Now:yyyyMMddHHmmss}.xlsx";

            return File(stream, contentType, fileName);
        }
    }
}
