using Shared.Kernel.Requests;

namespace Empresa.Application.Director.Dtos
{
    public class ListarDirectorPaginadoRequest : PagedRequest
    {
        public string Nombre { get; set; } = string.Empty;
        public bool? Estado { get; set; }
        public int? nIdEmpresa { get; set; }
    }
}
