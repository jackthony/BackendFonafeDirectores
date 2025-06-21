namespace Shared.ClientV1
{
    public class LstItemResponse<T> : BaseResponse
    {
        public IEnumerable<T> LstItem { get; set; } = [];
        public Pagination Pagination { get; set; } = new Pagination();
    }
}
