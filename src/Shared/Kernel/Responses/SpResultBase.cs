using Shared.Kernel.Interfaces;

namespace Shared.Kernel.Responses
{
    public class SpResultBase : ITrackableResponse, ISistemaResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public int Data { get; set; }

        public int ValorId => Data;

        public int? UsuarioId => Data;
        public string? GetSessionId => null;
    }
}
