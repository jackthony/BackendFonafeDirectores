/*****
 * Nombre del archivo:  EliminarArchivoParameters.cs
 * Descripción:         Clase que contiene los parámetros necesarios para realizar la eliminación de un archivo. 
 *                      Actualmente no contiene propiedades, pero está diseñada para extenderse en el futuro.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
namespace Archivo.Domain.Archivo.Parameters
{
    public class EliminarArchivoParameters
    {
        public required int ElementoId { get; set; }
        public required int UsuarioEliminacionId { get; set; }
        public DateTime FechaEliminacion { get; set; }
    }
}
