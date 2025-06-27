using Shared.Kernel.Requests;

namespace Empresa.Application.Empresa.Dtos
{
    public class ListarEmpresaPaginadoRequest : PagedRequest
    {
        public string? sRazonSocial { get; set; }
        public bool? bEstado { get; set; }
    }
}
