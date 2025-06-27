using Shared.Kernel.Requests;

namespace Empresa.Domain.Especialidad.Parameters
{
    public class ListarEspecialidadPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
