/*****
 * Nombre del archivo:  ListarSectorPaginadoRequest.cs
 * Descripción:         DTO que extiende PagedRequest para soportar la paginación
 *                      en la consulta de sectores, incluyendo filtros por nombre y estado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial del archivo.
 *****/

using Shared.Kernel.Requests;

namespace Empresa.Application.Sector.Dtos
{
    public class ListarSectorPaginadoRequest : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
