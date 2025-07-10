/*****
 * Nombre del archivo:  EliminarCargoRequestMapper.cs
 * Descripción:         Clase encargada de mapear una solicitud de eliminación de cargo (`EliminarCargoRequest`) a los parámetros necesarios para la base de datos (`EliminarCargoParameters`).
 *                      Asigna la fecha de modificación a la hora actual en UTC.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;

namespace Empresa.Application.Cargo.Mappers
{
    public class EliminarCargoRequestMapper : IMapper<EliminarCargoRequest, EliminarCargoParameters>
    {
        public EliminarCargoParameters Map(EliminarCargoRequest source)
        {
            return new EliminarCargoParameters
            {
                CargoId = source.nIdCargo,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = DateTime.UtcNow
            };

        }
    }
}
