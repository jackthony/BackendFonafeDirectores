namespace Shared.Kernel.Errors
{
    public class NotFoundError : ErrorBase
    {
        public NotFoundError(string code, string message)
            : base(code, message)
        {
        }
    }
}
