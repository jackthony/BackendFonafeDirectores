using Shared.Kernel.Requests;

namespace Empresa.Domain.TipoDirector.Parameters
{
    public class ListarTipoDirectorPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
