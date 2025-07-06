namespace Shared.Kernel.Interfaces
{
    public interface IAuditableResponse
    {
        int? UsuarioId { get; }
        string? DetallesAuditoria => null;
    }
}
