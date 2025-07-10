/***********
 * Nombre del archivo:  LoggingUseCaseDecorator.cs
 * Descripción:         Decorador para casos de uso que agrega funcionalidad de logging.
 *                      Registra información al iniciar la ejecución del caso de uso,
 *                      así como logs diferenciados para errores y ejecuciones exitosas.
 *                      Facilita el seguimiento y diagnóstico de las operaciones en la capa de aplicación.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del decorador para logging en casos de uso.
 ***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Api.Decorators
{
    public class LoggingUseCaseDecorator<TRequest, TResponse> : IUseCase<TRequest, TResponse>
    {
        private readonly IUseCase<TRequest, TResponse> _inner;
        private readonly ILogger<LoggingUseCaseDecorator<TRequest, TResponse>> _logger;

        public LoggingUseCaseDecorator(
            IUseCase<TRequest, TResponse> inner,
            ILogger<LoggingUseCaseDecorator<TRequest, TResponse>> logger)
        {
            _inner = inner;
            _logger = logger;
        }

        public async Task<OneOf<ErrorBase, TResponse>> ExecuteAsync(TRequest request)
        {
            _logger.LogInformation("Ejecutando {UseCase} con {Request}", typeof(TRequest).Name, request);
            var response = await _inner.ExecuteAsync(request);
            response.Switch(
                error => _logger.LogWarning("Error en {UseCase}: {Code} - {Message}", _inner.GetType().Name, error.Code, error.Message),
                success => _logger.LogInformation("Use case {UseCase} ejecutado exitosamente", _inner.GetType().Name)
            );
            return response;
        }
    }
}
