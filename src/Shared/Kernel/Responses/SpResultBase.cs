namespace Shared.Kernel.Responses
{
    public class SpResultBase
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public long Data { get; set; }
    }
}
