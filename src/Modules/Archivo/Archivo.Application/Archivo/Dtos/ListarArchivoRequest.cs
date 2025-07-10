/*****
 * Nombre del archivo:  ListarArchivoRequest.cs
 * Descripción:         Clase de transferencia de datos (DTO) utilizada para la solicitud de listado de archivos. 
 *                      Contiene las propiedades opcionales `nCarpetaPadreId`, `nDirectorId` y `nIdEmpresa` para filtrar los archivos según la carpeta, director y empresa correspondientes.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Application.Archivo.Dtos
{
    public class ListarArchivoRequest
    {
        public int? nCarpetaPadreId { get; set; } = null;
        public int? nDirectorId { get; set; } = null;
        public int? nIdEmpresa { get; set; } = null;
    }
}
