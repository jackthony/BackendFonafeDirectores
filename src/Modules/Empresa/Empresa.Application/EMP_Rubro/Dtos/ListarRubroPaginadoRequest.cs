using Shared.Kernel.Requests;

namespace Empresa.Application.Rubro.Dtos
{
    public class ListarRubroPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
