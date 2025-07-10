/*****
 * Nombre del archivo:  IExportImportService.cs
 * Descripción:         Interfaz que define los métodos para exportar e importar archivos. 
 *                      Incluye `ObtenerDatosExportAsync` para obtener datos de exportación y `ImportAsync` para procesar la importación de archivos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la interfaz.
 *****/
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Results;

namespace Archivo.Application.Archivo.Services
{
    public interface IExportImportService
    {
        public Stream ObtenerDatosExportAsync(List<EmpresaDocResult> empresas, List<DirectorDocResult> directores, int tipo);
        public ImportFileResult ImportAsync(ImportFileRequest request);
    }
}
