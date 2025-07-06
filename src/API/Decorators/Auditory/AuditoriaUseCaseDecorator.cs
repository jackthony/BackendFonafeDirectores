using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.SEG_Log.Dtos;
using Usuario.Application.SEG_Log.Services;

public class AuditoriaUseCaseDecorator<TRequest, TResponse> : IUseCase<TRequest, TResponse>
{
    private readonly IUseCase<TRequest, TResponse> _inner;
    private readonly ILogService _logService;

    public AuditoriaUseCaseDecorator(
        IUseCase<TRequest, TResponse> inner,
        ILogService logService)
    {
        _inner = inner;
        _logService = logService;
    }

    public async Task<OneOf<ErrorBase, TResponse>> ExecuteAsync(TRequest request)
    {
        var response = await _inner.ExecuteAsync(request);

        if (request is IAuditableRequest auditableRequest)
        {
            try
            {
                var logDto = new LogAuditoriaRequest
                {
                    UsuarioId = auditableRequest.UsuarioId,
                    Accion = auditableRequest.AccionAuditable,
                    Detalles = auditableRequest.DetallesAuditoria,
                };

                if (response.IsT1)
                {
                    var result = response.AsT1;
                    if (result is IAuditableResponse auditableResponse)
                    {
                        logDto.UsuarioId = auditableResponse.UsuarioId ?? logDto.UsuarioId;
                        logDto.Detalles = $"{logDto.Detalles} | {auditableResponse.DetallesAuditoria}";
                    }
                }

                await _logService.RegistrarAuditoriaAsync(logDto);
            }
            catch
            {
            }
        }

        return response;
    }
}
