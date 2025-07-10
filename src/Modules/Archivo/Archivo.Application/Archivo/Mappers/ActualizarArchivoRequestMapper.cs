/*****
 * Nombre del archivo:  ActualizarArchivoRequestMapper.cs
 * Descripción:         Clase encargada de mapear la solicitud de actualización de archivo (`ActualizarArchivoRequest`) a los parámetros necesarios para la operación (`ActualizarArchivoParameters`).
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
    public class ActualizarArchivoRequestMapper : IMapper<ActualizarArchivoRequest, ActualizarArchivoParameters>
    {
        public ActualizarArchivoParameters Map(ActualizarArchivoRequest source)
        {
            return new ActualizarArchivoParameters
            {
            };
        }
    }
}
