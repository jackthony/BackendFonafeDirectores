using OneOf;
using Shared.Kernel.Errors;
using Shared.Kernel.Interfaces;

namespace Api.Decorators
{
    public class ExceptionHandlingUseCaseDecorator<TRequest, TResponse> : IUseCase<TRequest, TResponse>
    {
        private readonly IUseCase<TRequest, TResponse> _inner;
        private readonly ILogger<ExceptionHandlingUseCaseDecorator<TRequest, TResponse>> _logger;

        public ExceptionHandlingUseCaseDecorator(
            IUseCase<TRequest, TResponse> inner,
            ILogger<ExceptionHandlingUseCaseDecorator<TRequest, TResponse>> logger)
        {
            _inner = inner;
            _logger = logger;
        }

        public async Task<OneOf<ErrorBase, TResponse>> ExecuteAsync(TRequest request)
        {
            try
            {
                return await _inner.ExecuteAsync(request);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió una excepción no controlada en el use case {UseCase}", _inner.GetType().Name);
                return ErrorBase.Unexpected(ex.Message);
            }
        }
    }
}
