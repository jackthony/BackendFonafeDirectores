/*****
 * Nombre del archivo:  ListarArchivoPaginadoRequest.cs
 * Descripción:         Clase de transferencia de datos (DTO) utilizada para la solicitud de listado paginado de archivos. 
 *                      Hereda de `PagedRequest` para manejar la paginación de la solicitud.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Requests;

namespace Archivo.Application.Archivo.Dtos
{
    public class ListarArchivoPaginadoRequest : PagedRequest
    {
    }
}
