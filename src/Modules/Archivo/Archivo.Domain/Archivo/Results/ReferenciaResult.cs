/*****
 * Nombre del archivo:  ReferenciaResult.cs
 * Descripción:         Clase que representa el resultado de una referencia en el contexto de los archivos. 
 *                      Contiene propiedades como `Id`, `Nombre` y `ReferenceId`, que definen la referencia dentro del sistema.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Domain.Archivo.Results
{
    public class ReferenciaResult
    {
        public required int Id { get; set; }
        public required string Nombre { get; set; }
        public int ReferenceId { get; set; }
    }
}
