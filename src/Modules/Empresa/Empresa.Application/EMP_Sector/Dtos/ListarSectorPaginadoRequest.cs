using Shared.Kernel.Requests;

<<<<<<< HEAD
namespace Empresa.Application.EMP_Sector.Dtos
{
    public class ListarSectorPaginadoRequest : PagedRequest
    {
=======
namespace Empresa.Application.Sector.Dtos
{
    public class ListarSectorPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
>>>>>>> origin/masterboa
    }
}
