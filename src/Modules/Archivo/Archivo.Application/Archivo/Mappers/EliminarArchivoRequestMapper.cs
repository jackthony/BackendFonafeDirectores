/*****
 * Nombre del archivo:  EliminarArchivoRequestMapper.cs
 * Descripción:         Clase encargada de mapear la solicitud de eliminación de archivo (`EliminarArchivoRequest`) 
 *                      a los parámetros necesarios para la operación (`EliminarArchivoParameters`).
 *                      Utiliza un proveedor de tiempo (`ITimeProvider`) para asignar la fecha de eliminación.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 15/07/25 por Daniel Alva
 * Cambios recientes:   Se agregó el uso de ITimeProvider para la fecha de eliminación.
 *****/
using Shared.Kernel.Interfaces;
using Shared.Time;
using Archivo.Application.Archivo.Dtos;
using Archivo.Domain.Archivo.Parameters;

namespace Archivo.Application.Archivo.Mappers
{
    public class EliminarArchivoRequestMapper : IMapper<EliminarArchivoRequest, EliminarArchivoParameters>
    {
        private readonly ITimeProvider _timeProvider;

        public EliminarArchivoRequestMapper(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }

        public EliminarArchivoParameters Map(EliminarArchivoRequest source)
        {
            return new EliminarArchivoParameters
            {
                ElementoId = source.ElementoId,
                UsuarioEliminacionId = source.UsuarioEliminacionId,
                FechaEliminacion = _timeProvider.NowPeru
            };
        }
    }
}
