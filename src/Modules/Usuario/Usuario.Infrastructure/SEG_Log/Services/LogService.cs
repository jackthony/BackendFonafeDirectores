/***********
 * Nombre del archivo:  LogService.cs
 * Descripción:         Implementación del servicio de registro de logs del sistema y trazabilidad.
 *                      Utiliza un proveedor de tiempo para estampar la fecha de registro y
 *                      delega la persistencia al repositorio correspondiente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación de métodos para registrar logs del sistema y trazabilidad.
 ***********/

using Shared.Time;
using Usuario.Application.SEG_Log.Dtos;
using Usuario.Application.SEG_Log.Services;
using Usuario.Domain.SEG_Log.Repositories;
using Usuario.Domain.SEG_Log.Parameters;

namespace Usuario.Infrastructure.SEG_Log.Services
{
    public class LogService : ILogService
    {
        private readonly ITimeProvider _timeProvider;
        private readonly ILogRepository _logRepository;

        public LogService(ITimeProvider timeProvider, ILogRepository logRepository)
        {
            _timeProvider = timeProvider;
            _logRepository = logRepository;
        }

        public async Task RegistrarSistemaAsync(LogSistemaRequest request)
        {
            var parameters = new LogSistemaParameters
            {
                UsuarioId = request.UsuarioId ?? 0,
                TipoEvento = request.TipoEvento,
                Mensaje = request.Mensaje,
                IdSession = request.IdSession,
                Ip = request.Ip,
                Origen = request.Origen,
                StackTrace = request.StackTrace,
                Estado = request.Estado ?? 0,
                Fecha = _timeProvider.NowPeru
            };

            await _logRepository.RegistrarSistemaAsync(parameters);
        }

        public async Task RegistrarTrazabilidadAsync(LogTrazabilidadRequest request)
        {
            var parameters = new LogTrazabilidadParameters
            {
                UsuarioId = request.UsuarioId,
                Modulo = request.Modulo,
                Entidad = request.Entidad,
                Movimiento = request.Movimiento,
                DatosAntes = request.DatosAntes,
                DatosDespues = request.DatosDespues,
                IdSession = request.IdSesion,
                Fecha = _timeProvider.NowPeru,
                Detalles = request.Detalles
            };

            await _logRepository.RegistrarTrazabilidadAsync(parameters);
        }
    }
}
