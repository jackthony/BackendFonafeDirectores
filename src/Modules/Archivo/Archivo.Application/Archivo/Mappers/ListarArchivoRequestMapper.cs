/*****
 * Nombre del archivo:  ListarArchivoRequestMapper.cs
 * Descripción:         Clase encargada de mapear la solicitud de listado de archivos (`ListarArchivoRequest`) a los parámetros necesarios para la operación de listado (`ListarArchivoParameters`).
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;

namespace Archivo.Application.Archivo.Mappers
{
    public class ListarArchivoRequestMapper : IMapper<ListarArchivoRequest, ListarArchivoParameters>
    {
        public ListarArchivoParameters Map(ListarArchivoRequest source)
        {
            return new ListarArchivoParameters
            {
                CarpetaPadreId = source.nCarpetaPadreId,
                DirectorId = source.nDirectorId,
                IdEmpresa = source.nIdEmpresa,
            };
        }
    }
}
