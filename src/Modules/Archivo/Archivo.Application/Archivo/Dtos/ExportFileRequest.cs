/*****
 * Nombre del archivo:  ExportFileRequest.cs
 * Descripción:         Clase de transferencia de datos (DTO) utilizada para la solicitud de exportación de archivos. 
 *                      Contiene la propiedad `nTipoArchivo` que define el tipo de archivo a exportar.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Application.Archivo.Dtos
{
    public class ExportFileRequest
    {
        public int nTipoArchivo { get; set; }
    }
}
