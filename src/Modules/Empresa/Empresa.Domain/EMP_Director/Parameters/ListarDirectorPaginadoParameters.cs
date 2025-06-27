using Shared.Kernel.Requests;

namespace Empresa.Domain.Director.Parameters
{
    public class ListarDirectorPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
        public int? nIdEmpresa { get; set; }
    }
}
