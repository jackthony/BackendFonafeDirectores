namespace Shared.Kernel.Errors
{
    public class ControllerError : ErrorBase
    {
        public Dictionary<string, string[]>? Errors { get; }

        public ControllerError(string code, string message, Dictionary<string, string[]>? errors = null)
            : base(code, message)
        {
            Errors = errors;
        }
    }
}
