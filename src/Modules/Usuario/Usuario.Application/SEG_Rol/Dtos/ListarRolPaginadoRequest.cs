using Shared.Kernel.Requests;

namespace Usuario.Application.Rol.Dtos
{
    public class ListarRolPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
