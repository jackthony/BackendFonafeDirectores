using Shared.Kernel.Requests;

namespace Empresa.Application.Cargo.Dtos
{
    public class ListarCargoPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
