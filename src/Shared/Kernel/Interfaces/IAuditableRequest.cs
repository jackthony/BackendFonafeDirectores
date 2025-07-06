namespace Shared.Kernel.Interfaces
{
    public interface IAuditableRequest
    {
        int? UsuarioId { get; }
        string AccionAuditable { get; }
        string? DetallesAuditoria => null;
    }
}
