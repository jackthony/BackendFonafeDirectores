/*****
 * Nombre del archivo:  ListarDirectorPaginadoRequest.cs
 * Descripción:         Clase que representa una solicitud paginada para listar directores en el sistema. 
 *                      Incluye propiedades como `Nombre` (para filtrar por el nombre del director), `Estado` (para filtrar por el estado) y `nIdEmpresa` (para filtrar por el ID de la empresa).
 *                      Hereda de `PagedRequest` para facilitar la paginación de los resultados.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
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
