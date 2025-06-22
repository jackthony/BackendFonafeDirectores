namespace Shared.Kernel.Interfaces
{
    public interface IPresenter<TClientRequest, TInternalRequest, TInternalDto, TClientResponse>
    {
        TInternalRequest ToRequest(TClientRequest clientRequest);
        TClientResponse ToResponse(TInternalDto dto);
    }
}
