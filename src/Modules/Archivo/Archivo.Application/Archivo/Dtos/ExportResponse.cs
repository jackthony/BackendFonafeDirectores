/*****
 * Nombre del archivo:  ExportResponse.cs
 * Descripción:         Clase de transferencia de datos (DTO) utilizada para la respuesta de una solicitud de exportación de archivos. 
 *                      Contiene las propiedades `EmpresaDocs` y `DirectorDocs`, que son listas de resultados relacionados con los documentos de empresa y director.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Archivo.Domain.Archivo.Results;

namespace Archivo.Application.Archivo.Dtos
{
    public class ExportResponse
    {
        public List<EmpresaDocResult> EmpresaDocs { get; set; } = [];
        public List<DirectorDocResult> DirectorDocs { get; set; } = [];
    }
}
