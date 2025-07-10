/*****
 * Nombre de clase:     EliminarMinisterioRequestMapper
 * Descripción:         Mapper encargado de transformar el DTO EliminarMinisterioRequest
 *                      en el parámetro EliminarMinisterioParameters utilizado en la capa de dominio.
 *                      Asigna la fecha de modificación con la hora UTC actual.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para realizar el mapeo entre el request de eliminación y los parámetros de dominio.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;

namespace Empresa.Application.Ministerio.Mappers
{
    public class EliminarMinisterioRequestMapper : IMapper<EliminarMinisterioRequest, EliminarMinisterioParameters>
    {
        public EliminarMinisterioParameters Map(EliminarMinisterioRequest source)
        {
            return new EliminarMinisterioParameters
            {
                MinisterioId = source.nIdMinisterio,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = DateTime.UtcNow
            };
        }
    }
}
