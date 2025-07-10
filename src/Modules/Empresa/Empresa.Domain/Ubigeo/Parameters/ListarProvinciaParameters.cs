/***********
 * Nombre del archivo:  ListarProvinciaParameters.cs
 * Descripción:         Clase que encapsula los parámetros necesarios para listar provincias.
 *                      Incluye el ID del departamento asociado y un nombre opcional como filtro.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de los parámetros de búsqueda para provincias.
 ***********/

namespace Empresa.Domain.Ubigeo.Parameters
{
    public class ListarProvinciaParameters
    {
        public int DepartamentoId { get; set; }
        public string? Nombre { get; set; }
    }
}
