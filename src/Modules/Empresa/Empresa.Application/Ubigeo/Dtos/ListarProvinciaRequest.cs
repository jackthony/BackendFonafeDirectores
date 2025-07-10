/*****
 * Nombre del archivo:  ListarProvinciaRequest.cs
 * Descripción:         DTO que representa la solicitud para listar provincias. Contiene los campos
 *                      necesarios para filtrar la búsqueda, como el código del departamento y el nombre.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

namespace Empresa.Application.Ubigeo.Dtos
{
    public class ListarProvinciaRequest
    {
        public required string  sCode { get; set; }
        public string? sNombre { get; set; }
    }
}
