/*****
 * Nombre del archivo:  ListarArchivoPaginadoParameters.cs
 * Descripción:         Clase que hereda de `PagedRequest` para representar los parámetros necesarios para realizar un listado paginado de archivos. 
 *                      Se utiliza para manejar la paginación en las solicitudes de archivos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Requests;

namespace Archivo.Domain.Archivo.Parameters
{
    public class ListarArchivoPaginadoParameters : PagedRequest
    {
    }
}
