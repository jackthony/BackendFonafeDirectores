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

        public async Task RegistrarAuditoriaAsync(LogAuditoriaRequest request)
        {
            var parameters = new LogAuditoriaParameters
            {
                UsuarioId = request.UsuarioId ?? 0,
                Accion = request.Accion,
                Detalles = request.Detalles,
                Fecha = _timeProvider.NowPeru
            };

            await _logRepository.RegistrarAuditoriaAsync(parameters);
        }

        public async Task RegistrarSistemaAsync(LogSistemaRequest request)
        {
            var parameters = new LogSistemaParameters
            {
                /*UsuarioId = dto.UsuarioId,
                TipoEvento = dto.TipoEvento,
                Mensaje = dto.Mensaje,
                StackTrace = dto.StackTrace,
                Origen = dto.Origen,
                Endpoint = dto.Endpoint,
                Estado = dto.Estado,
                Fecha = _timeProvider.Now*/
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
                Fecha = _timeProvider.NowPeru,
                Detalles = request.Detalles
            };

            await _logRepository.RegistrarTrazabilidadAsync(parameters);
        }
    }
}
