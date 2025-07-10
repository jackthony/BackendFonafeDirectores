/*****
 * Nombre del archivo:  EliminarTipoDirectorRequestMapper.cs
 * Descripción:         Mapeador que transforma un objeto EliminarTipoDirectorRequest en
 *                      EliminarTipoDirectorParameters, agregando la fecha de modificación
 *                      para ser utilizado en la operación de eliminación lógica.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.TipoDirector.Dtos;
using Empresa.Domain.TipoDirector.Parameters;

namespace Empresa.Application.TipoDirector.Mappers
{
    public class EliminarTipoDirectorRequestMapper : IMapper<EliminarTipoDirectorRequest, EliminarTipoDirectorParameters>
    {
        public EliminarTipoDirectorParameters Map(EliminarTipoDirectorRequest source)
        {
            return new EliminarTipoDirectorParameters
            {
                TipoDirectorId = source.nIdTipoDirector,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = DateTime.UtcNow
            };
        }
    }
}
