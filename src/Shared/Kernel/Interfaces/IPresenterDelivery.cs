namespace Shared.Kernel.Interfaces
{
    public interface IPresenterDelivery<TInput, TOutput>
    {
        TOutput Present(TInput input);
    }

}
