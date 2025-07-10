/***********
 * Nombre del archivo:  ListarEspecialidadPaginadoParameters.cs
 * Descripción:         Clase que encapsula los parámetros para listar especialidades con paginación,
 *                      permitiendo filtrar por nombre y estado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada con herencia de PagedRequest y filtros por nombre y estado.
 ***********/

using Shared.Kernel.Requests;

namespace Empresa.Domain.Especialidad.Parameters
{
    public class ListarEspecialidadPaginadoParameters : PagedRequest
    {
        public string? Nombre { get; set; }
        public bool? Estado { get; set; }
    }
}
