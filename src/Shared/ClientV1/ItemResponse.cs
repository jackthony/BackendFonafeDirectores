namespace Shared.ClientV1
{
    public class ItemResponse<T> : BaseResponse
    {
        public T? Item { get; set; }
    }
}
