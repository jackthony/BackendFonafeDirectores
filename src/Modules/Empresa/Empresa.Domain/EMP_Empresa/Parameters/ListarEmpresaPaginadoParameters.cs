/***********
 * Nombre del archivo:  ListarEmpresaPaginadoParameters.cs
 * Descripción:         Clase de parámetros para listar empresas de forma paginada.
 *                      Hereda de PagedRequest e incluye filtros opcionales como razón social y estado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para soportar consultas paginadas con filtros.
 ***********/

using Shared.Kernel.Requests;

namespace Empresa.Domain.Empresa.Parameters
{
    public class ListarEmpresaPaginadoParameters : PagedRequest
    {
        public string? RazonSocial { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaIncio { get; set; }
        public DateTime? FechaFin {  get; set; }
    }
}
