namespace Shared.ClientV1
{
    public class TreeResponse<T> : BaseResponse
    {
        public List<T> LstItem { get; set; } = [];
    }
}
