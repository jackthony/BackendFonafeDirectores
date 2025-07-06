namespace Shared.Kernel.Interfaces
{
    public interface ISistemaRequest
    {
        int? UsuarioId { get; }
        string? Origen { get; }
        int? Estado { get; }
        string? Mensaje { get; }
        string? TipoEvento { get; }
    }
}
