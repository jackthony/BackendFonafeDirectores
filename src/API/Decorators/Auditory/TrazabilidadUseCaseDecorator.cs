/***********
 * Nombre del archivo:  TrazabilidadUseCaseDecorator.cs
 * Descripción:         Decorador para casos de uso que agrega trazabilidad y auditoría.
 *                      Intercepta la ejecución del caso de uso para capturar el estado
 *                      antes y después de la operación, y registra la información relevante
 *                      en un log de trazabilidad.
 *                      
 *                      - Solo actúa sobre solicitudes que implementan ITrackableRequest.
 *                      - Obtiene estado previo para movimientos distintos de "Create".
 *                      - Obtiene estado posterior para movimientos distintos de "Delete".
 *                      - Extrae el Id de sesión del contexto HTTP para asociar el log.
 *                      - Registra los datos en el servicio de log mediante LogTrazabilidadRequest.
 *                      
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del decorador para agregar trazabilidad a los casos de uso.
 ***********/

using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.SEG_Log.Dtos;
using Usuario.Application.SEG_Log.Services;
using Usuario.Domain.SEG_Log.Repositories;

public class TrazabilidadUseCaseDecorator<TRequest, TResponse> : IUseCase<TRequest, TResponse>
{
    private readonly IUseCase<TRequest, TResponse> _inner;
    private readonly ILogService _logService;
    private readonly ITrazabilidadInspector _inspector;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public TrazabilidadUseCaseDecorator(
        IUseCase<TRequest, TResponse> inner,
        ILogService logService,
        ITrazabilidadInspector inspector,
        IHttpContextAccessor httpContextAccessor)
    {
        _inner = inner;
        _logService = logService;
        _inspector = inspector;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<OneOf<ErrorBase, TResponse>> ExecuteAsync(TRequest request)
    {
        if (request is not ITrackableRequest trackableRequest)
            return await _inner.ExecuteAsync(request);

        string? datosAntes = null;
        string? datosDespues = null;

        try
        {
            if (trackableRequest.Movimiento != "Create")
            {
                datosAntes = await _inspector.ObtenerEstadoActualAsync(
                    trackableRequest.Tabla,
                    trackableRequest.CampoId,
                    trackableRequest.ValorId ?? 0);
            }
        }
        catch
        {
        }

        var response = await _inner.ExecuteAsync(request);

        try
        {
            if (trackableRequest.Movimiento != "Delete")
            {
                var valorId = trackableRequest.ValorId ?? 0;
                if (response.IsT1)
                {
                    var success = response.AsT1;
                    if (success is ITrackableResponse trackableResponse)
                    {
                        valorId = trackableResponse.ValorId;
                    }
                }
                datosDespues = await _inspector.ObtenerEstadoActualAsync(
                    trackableRequest.Tabla,
                    trackableRequest.CampoId,
                    valorId);
            }

            string? sessionId = _httpContextAccessor.HttpContext?.User.FindFirst("sid")?.Value;

            var logDto = new LogTrazabilidadRequest
            {
                UsuarioId = trackableRequest.UsuarioId,
                Modulo = trackableRequest.Modulo,
                Entidad = trackableRequest.Tabla,
                Movimiento = trackableRequest.Movimiento,
                DatosAntes = datosAntes,
                DatosDespues = datosDespues,
                Detalles = trackableRequest.DetallesTrazabilidad,
                IdSesion = sessionId
            };

            await _logService.RegistrarTrazabilidadAsync(logDto);
        }
        catch
        {
        }

        return response;
    }
}
