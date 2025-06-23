using Shared.Kernel.Requests;

namespace Empresa.Application.TipoDirector.Dtos
{
    public class ListarTipoDirectorPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
