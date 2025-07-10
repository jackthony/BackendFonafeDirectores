/***********
 * Nombre del archivo:  DistritoResponse.cs
 * Descripción:         Clase DTO que representa la respuesta de un distrito.
 *                      Contiene el código del distrito, su nombre y el código de la provincia a la que pertenece.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la estructura de respuesta para distritos.
 ***********/

namespace Empresa.Presentation.Ubigeo.Responses
{
    public class DistritoResponse
    {
        public required string sCode { get; set; }
        public required string sName { get; set; }
        public required string sProvinceCode { get; set; }
    }
}
