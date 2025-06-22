namespace Shared.Kernel.Errors
{
    public class ValidationError : ErrorBase
    {
        public Dictionary<string, string[]>? Errors { get; }

        public ValidationError(string code, string message, Dictionary<string, string[]>? errors = null)
            : base(code, message)
        {
            Errors = errors;
        }
    }
}
