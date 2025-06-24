using Shared.Kernel.Requests;

namespace Empresa.Domain.Empresa.Parameters
{
    public class ListarEmpresaPaginadoParameters : PagedRequest
    {
        public string? RazonSocial { get; set; }
        public bool? Estado { get; set; }
    }
}
