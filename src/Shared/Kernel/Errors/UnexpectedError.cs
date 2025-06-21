namespace Shared.Kernel.Errors
{
    public class UnexpectedError : ErrorBase
    {
        public UnexpectedError(string code, string message) : base(code, message) { }
    }
}
