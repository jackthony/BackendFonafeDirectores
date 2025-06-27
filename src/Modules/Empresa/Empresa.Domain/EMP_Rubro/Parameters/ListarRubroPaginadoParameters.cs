using Shared.Kernel.Requests;

namespace Empresa.Domain.Rubro.Parameters
{
    public class ListarRubroPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
