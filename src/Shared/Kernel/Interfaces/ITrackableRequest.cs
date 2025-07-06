
namespace Shared.Kernel.Interfaces
{
    public interface ITrackableRequest
    {
        public int UsuarioId { get; }
        public string Modulo { get; }
        public string Tabla { get; }
        public string CampoId { get; }
        public int ValorId { get; }
        public string Movimiento { get; }
        public string? DetallesTrazabilidad => null;
    }
}
