/***********
 * Nombre del archivo:  DepartamentoResponse.cs
 * Descripción:         Clase DTO que representa la respuesta de un departamento.
 *                      Incluye el código del departamento y su nombre.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación inicial del DTO DepartamentoResponse.
 ***********/

namespace Empresa.Presentation.Ubigeo.Responses
{
    public class DepartamentoResponse
    {
        public required string sCode { get; set; }
        public required string sName { get; set; }
    }
}
