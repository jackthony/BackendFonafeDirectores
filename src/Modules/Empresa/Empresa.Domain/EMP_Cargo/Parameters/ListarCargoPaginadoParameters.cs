using Shared.Kernel.Requests;

namespace Empresa.Domain.Cargo.Parameters
{
    public class ListarCargoPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
