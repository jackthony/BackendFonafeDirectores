using Shared.Kernel.Requests;

namespace Empresa.Application.Ministerio.Dtos
{
    public class ListarMinisterioPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
