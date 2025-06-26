using Shared.Kernel.Requests;

namespace Empresa.Application.Especialidad.Dtos
{
    public class ListarEspecialidadPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
