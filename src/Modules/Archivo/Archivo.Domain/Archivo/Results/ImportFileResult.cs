/*****
 * Nombre del archivo:  ImportFileResult.cs
 * Descripción:         Clase que representa el resultado de la importación de un archivo. 
 *                      Contiene listas de `Empresas` y `Directores` que fueron procesados a partir del archivo importado.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Domain.Archivo.Results
{
    public class ImportFileResult
    {
        public List<EmpresaDocResult> Empresas { get; set; } = new();
        public List<DirectorDocResult> Directores { get; set; } = new();
    }
}
