/***********
 * Nombre del archivo:  ListarRubroPaginadoParameters.cs
 * Descripción:         Clase que encapsula los parámetros necesarios para listar rubros de forma paginada,
 *                      incluyendo nombre como filtro opcional y estado (activo/inactivo).
 *                      Hereda de PagedRequest para soportar paginación estándar.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial para parámetros de listado paginado de rubros.
 ***********/

using Shared.Kernel.Requests;

namespace Empresa.Domain.Rubro.Parameters
{
    public class ListarRubroPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
