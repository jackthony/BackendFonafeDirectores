using OneOf;
using Shared.Kernel.Errors;

namespace Shared.Kernel.Interfaces
{
    public interface IUseCase<TRequest, TResponse>
    {
        public Task<OneOf<ErrorBase, TResponse>> ExecuteAsync(TRequest request);
    }
}
