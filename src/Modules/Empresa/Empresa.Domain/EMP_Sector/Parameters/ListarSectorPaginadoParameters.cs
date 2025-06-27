using Shared.Kernel.Requests;

namespace Empresa.Domain.Sector.Parameters
{
    public class ListarSectorPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
