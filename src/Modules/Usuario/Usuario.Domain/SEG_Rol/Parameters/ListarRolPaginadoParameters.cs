using Shared.Kernel.Requests;

namespace Usuario.Domain.Rol.Parameters
{
    public class ListarRolPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
