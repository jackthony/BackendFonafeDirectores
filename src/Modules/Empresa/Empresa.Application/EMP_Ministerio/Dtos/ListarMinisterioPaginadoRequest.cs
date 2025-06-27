using Shared.Kernel.Requests;

<<<<<<< HEAD
namespace Empresa.Application.EMP_Ministerio.Dtos
{
    public class ListarMinisterioPaginadoRequest : PagedRequest
    {
=======
namespace Empresa.Application.Ministerio.Dtos
{
    public class ListarMinisterioPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
>>>>>>> origin/masterboa
    }
}
