/*****
 * Nombre del archivo:  ListarArchivoParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios para realizar el listado de archivos. 
 *                      Incluye propiedades opcionales como `CarpetaPadreId`, `DirectorId` y `IdEmpresa` para filtrar los archivos en la consulta.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Domain.Archivo.Parameters
{
    public class ListarArchivoParameters
    {
        public int? CarpetaPadreId { get; set; } = null;
        public int? DirectorId { get; set; } = null;
        public int? IdEmpresa { get; set; } = null;
    }
}
