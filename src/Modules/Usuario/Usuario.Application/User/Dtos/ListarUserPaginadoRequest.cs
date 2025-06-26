using Shared.Kernel.Requests;

namespace Usuario.Application.User.Dtos
{
    public class ListarUserPaginadoRequest : PagedRequest
    {
        public string? sNombreCompleto { get; set; }
        public bool? bIsEstado { get; set; }
    }
}
