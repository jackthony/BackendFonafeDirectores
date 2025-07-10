/*****
 * Nombre de clase:     ListarEspecialidadPaginadoRequest
 * Descripción:         DTO para listar especialidades con paginación y filtros opcionales.
 *                      Hereda de PagedRequest para manejo de página y tamaño.
 * Propiedades:
 *  - Nombre: filtro opcional para nombre de especialidad.
 *  - Estado: filtro opcional para estado activo/inactivo.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para soporte a listado paginado de especialidades.
 *****/

using Shared.Kernel.Requests;

namespace Empresa.Application.Especialidad.Dtos
{
    public class ListarEspecialidadPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
