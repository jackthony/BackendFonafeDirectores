namespace Shared.Kernel.Interfaces
{
    public interface ISistemaResponse
    {
        int? UsuarioId { get; }
        string? GetSessionId { get; }
    }
}
