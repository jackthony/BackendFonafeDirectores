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

    public TrazabilidadUseCaseDecorator(
        IUseCase<TRequest, TResponse> inner,
        ILogService logService,
        ITrazabilidadInspector inspector)
    {
        _inner = inner;
        _logService = logService;
        _inspector = inspector;
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
                    trackableRequest.ValorId);
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
                datosDespues = await _inspector.ObtenerEstadoActualAsync(
                    trackableRequest.Tabla,
                    trackableRequest.CampoId,
                    trackableRequest.ValorId);
            }

            var logDto = new LogTrazabilidadRequest
            {
                UsuarioId = trackableRequest.UsuarioId,
                Modulo = trackableRequest.Modulo,
                Entidad = trackableRequest.Tabla,
                Movimiento = trackableRequest.Movimiento,
                DatosAntes = datosAntes,
                DatosDespues = datosDespues,
                Detalles = trackableRequest.DetallesTrazabilidad
            };

            await _logService.RegistrarTrazabilidadAsync(logDto);
        }
        catch
        {
        }

        return response;
    }
}
