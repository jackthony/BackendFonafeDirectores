/*****
 * Nombre del archivo:  ImportFileRequest.cs
 * Descripción:         Clase de transferencia de datos (DTO) utilizada para la solicitud de importación de archivos. 
 *                      Contiene las propiedades `Archivo` (de tipo IFormFile) para representar el archivo a importar y `nUsuarioId` para identificar al usuario que realiza la importación.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Microsoft.AspNetCore.Http;

namespace Archivo.Application.Archivo.Dtos
{
    public class ImportFileRequest
    {
        public IFormFile Archivo { get; set; } = default!;
        public int nUsuarioId { get; set; }
    }
}
