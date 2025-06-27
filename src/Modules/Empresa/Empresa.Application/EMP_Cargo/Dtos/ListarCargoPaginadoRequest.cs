using Shared.Kernel.Requests;

<<<<<<< HEAD
namespace Empresa.Application.EMP_Cargo.Dtos
{
    public class ListarCargoPaginadoRequest : PagedRequest
    {
=======
namespace Empresa.Application.Cargo.Dtos
{
    public class ListarCargoPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
>>>>>>> origin/masterboa
    }
}
