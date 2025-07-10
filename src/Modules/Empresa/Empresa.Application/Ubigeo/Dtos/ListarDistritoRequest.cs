/*****
 * Nombre del archivo:  ListarDistritoRequest.cs
 * Descripción:         DTO que representa la solicitud para listar distritos. Contiene el código de la provincia
 *                      y el nombre como criterios opcionales de búsqueda.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

namespace Empresa.Application.Ubigeo.Dtos
{
    public class ListarDistritoRequest
    {
        public required string sCode { get; set; }
        public string? sNombre { get; set; }
    }
}
