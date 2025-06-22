namespace Shared.ClientV1
{
    public abstract class BaseResponse : BaseRequest
    {
        public bool IsSuccess { get; set; } = false;
        public List<string> LstError { get; set; } = [];
    }
}
