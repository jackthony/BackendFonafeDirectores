/*****
 * Nombre de clase:     EliminarRubroRequestMapper
 * Descripción:         Mapper encargado de transformar el DTO EliminarRubroRequest
 *                      en el parámetro EliminarRubroParameters utilizado en la capa de dominio.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para realizar el mapeo entre el request de eliminación y los parámetros de dominio.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;

namespace Empresa.Application.Rubro.Mappers
{
    public class EliminarRubroRequestMapper : IMapper<EliminarRubroRequest, EliminarRubroParameters>
    {
        public EliminarRubroParameters Map(EliminarRubroRequest source)
        {
            return new EliminarRubroParameters
            {
                RubroId = source.nIdRubro,
                UsuarioModificacionId = source.nUsuarioModificacion,
                FechaModificacion = DateTime.UtcNow
            };
        }
    }
}
