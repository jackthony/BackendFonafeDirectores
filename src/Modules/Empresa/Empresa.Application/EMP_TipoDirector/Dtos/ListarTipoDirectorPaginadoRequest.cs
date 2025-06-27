using Shared.Kernel.Requests;

<<<<<<< HEAD
namespace Empresa.Application.EMP_TipoDirector.Dtos
{
    public class ListarTipoDirectorPaginadoRequest : PagedRequest
    {
=======
namespace Empresa.Application.TipoDirector.Dtos
{
    public class ListarTipoDirectorPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
>>>>>>> origin/masterboa
    }
}
