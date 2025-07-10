/*****
 * Nombre del archivo:  DataArchivoDto.cs
 * Descripción:         Clase de transferencia de datos (DTO) que representa la información relacionada con un archivo. 
 *                      Contiene las propiedades para la URL y el nombre del archivo.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Application.Archivo.Dtos
{
    public class DataArchivoDto
    {
        public required string Url { get; set; }
        public required string Name {  get; set; }
    }
}
