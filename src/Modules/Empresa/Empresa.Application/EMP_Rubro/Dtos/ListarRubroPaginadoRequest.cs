using Shared.Kernel.Requests;

<<<<<<< HEAD
namespace Empresa.Application.EMP_Rubro.Dtos
{
    public class ListarRubroPaginadoRequest : PagedRequest
    {
=======
namespace Empresa.Application.Rubro.Dtos
{
    public class ListarRubroPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
>>>>>>> origin/masterboa
    }
}
