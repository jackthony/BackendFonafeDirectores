using Shared.Kernel.Requests;

namespace Usuario.Domain.User.Parameters
{
    public class ListarUserPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
