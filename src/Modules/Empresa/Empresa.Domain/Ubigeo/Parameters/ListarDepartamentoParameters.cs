/***********
 * Nombre del archivo:  ListarDepartamentoParameters.cs
 * Descripción:         Clase que encapsula el parámetro opcional de nombre para filtrar
 *                      la lista de departamentos en consultas del módulo Ubigeo.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de los parámetros de búsqueda para departamentos.
 ***********/

namespace Empresa.Domain.Ubigeo.Parameters
{
    public class ListarDepartamentoParameters
    {
        public string? Nombre { get; set; }
    }
}
