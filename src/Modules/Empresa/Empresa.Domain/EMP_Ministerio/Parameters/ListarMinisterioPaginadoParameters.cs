using Shared.Kernel.Requests;

namespace Empresa.Domain.Ministerio.Parameters
{
    public class ListarMinisterioPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
