/***********
 * Nombre del archivo:  ListarDistritoParameters.cs
 * Descripción:         Clase que define los parámetros necesarios para listar distritos,
 *                      incluyendo el ID de la provincia y un nombre opcional como filtro.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de los parámetros de búsqueda para distritos.
 ***********/

namespace Empresa.Domain.Ubigeo.Parameters
{
    public class ListarDistritoParameters
    {
        public int ProvinciaId { get; set; }
        public string? Nombre { get; set; }
    }
}
