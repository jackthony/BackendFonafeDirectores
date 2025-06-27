using Shared.Kernel.Requests;

<<<<<<< HEAD
namespace Empresa.Application.EMP_Especialidad.Dtos
{
    public class ListarEspecialidadPaginadoRequest : PagedRequest
    {
=======
namespace Empresa.Application.Especialidad.Dtos
{
    public class ListarEspecialidadPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
>>>>>>> origin/masterboa
    }
}
