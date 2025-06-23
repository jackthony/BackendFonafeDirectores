using Shared.Kernel.Requests;

namespace Empresa.Application.Sector.Dtos
{
    public class ListarSectorPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
