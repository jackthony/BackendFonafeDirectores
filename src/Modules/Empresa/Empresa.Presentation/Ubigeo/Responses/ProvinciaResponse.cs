/***********
 * Nombre del archivo:  ProvinciaResponse.cs
 * Descripción:         Clase DTO para representar la respuesta de una provincia.
 *                      Contiene el código de la provincia, su nombre y el código del departamento al que pertenece.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Implementación inicial del DTO ProvinciaResponse.
 ***********/

namespace Empresa.Presentation.Ubigeo.Responses
{
    public class ProvinciaResponse
    {
        public required string sCode { get; set; }
        public required string sName { get; set;}
        public required string sDepartmentCode { get; set; }
    }
}
