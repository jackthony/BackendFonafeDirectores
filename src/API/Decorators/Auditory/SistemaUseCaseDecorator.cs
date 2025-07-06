using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;
using Usuario.Application.SEG_Log.Dtos;
using Usuario.Application.SEG_Log.Services;

public class SistemaUseCaseDecorator<TRequest, TResponse> : IUseCase<TRequest, TResponse>
{
    private readonly IUseCase<TRequest, TResponse> _inner;
    private readonly ILogService _logService;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public SistemaUseCaseDecorator(IUseCase<TRequest, TResponse> inner, ILogService logService, IHttpContextAccessor httpContextAccessor)
    {
        _inner = inner;
        _logService = logService;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<OneOf<ErrorBase, TResponse>> ExecuteAsync(TRequest request)
    {
        var response = await _inner.ExecuteAsync(request);

        if (request is ISistemaRequest auditableRequest)
        {

            try
            {
                var logDto = new LogSistemaRequest
                {
                    UsuarioId = auditableRequest.UsuarioId,
                    Estado = auditableRequest.Estado,
                    Mensaje = auditableRequest.Mensaje,
                    Origen = auditableRequest.Origen,
                    TipoEvento = auditableRequest.TipoEvento,
                };

                if (response.IsT1)
                {
                    var result = response.AsT1;
                    if (result is ISistemaResponse auditableResponse)
                    {
                        logDto.UsuarioId = auditableResponse.UsuarioId ?? logDto.UsuarioId;
                        logDto.IdSession = auditableResponse.GetSessionId ?? "";
                        string? ip = _httpContextAccessor.HttpContext?.Connection?.RemoteIpAddress?.ToString();
                        logDto.Ip = ip;
                    }
                }

                await _logService.RegistrarSistemaAsync(logDto);
            }
            catch
            {
            }
        }

        return response;
    }
}
