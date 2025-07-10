/*****
 * Nombre del archivo:  ListarArchivoPaginadoRequestMapper.cs
 * Descripción:         Clase encargada de mapear la solicitud de listado paginado de archivos (`ListarArchivoPaginadoRequest`) a los parámetros necesarios para la operación de listado paginado (`ListarArchivoPaginadoParameters`).
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;

namespace Archivo.Application.Archivo.Mappers
{
    public class ListarArchivoPaginadoRequestMapper : IMapper<ListarArchivoPaginadoRequest, ListarArchivoPaginadoParameters>
    {
        public ListarArchivoPaginadoParameters Map(ListarArchivoPaginadoRequest source)
        {
            return new ListarArchivoPaginadoParameters
            {
            };
        }
    }
}
