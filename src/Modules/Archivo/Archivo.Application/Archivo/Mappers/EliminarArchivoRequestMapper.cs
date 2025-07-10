/*****
 * Nombre del archivo:  EliminarArchivoRequestMapper.cs
 * Descripción:         Clase encargada de mapear la solicitud de eliminación de archivo (`EliminarArchivoRequest`) a los parámetros necesarios para la operación (`EliminarArchivoParameters`).
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
    public class EliminarArchivoRequestMapper : IMapper<EliminarArchivoRequest, EliminarArchivoParameters>
    {
        public EliminarArchivoParameters Map(EliminarArchivoRequest source)
        {
            return new EliminarArchivoParameters
            {
            };
        }
    }
}
