/***********
 * Nombre del archivo:  ListarCargoPaginadoParameters.cs
 * Descripción:         Clase que contiene los parámetros para listar cargos con paginación y filtros opcionales.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación de la clase para parámetros paginados de cargos.
 ***********/

using Shared.Kernel.Requests;

namespace Empresa.Domain.Cargo.Parameters
{
    public class ListarCargoPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
