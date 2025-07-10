/*****
 * Nombre de clase:     ListarMinisterioRequestMapper
 * Descripción:         Mapper encargado de transformar el DTO ListarMinisterioRequest
 *                      en el parámetro ListarMinisterioParameters utilizado en la capa de dominio.
 *                      Actualmente no se asignan propiedades específicas en el mapeo.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada como base para futuras asignaciones de filtros en el listado de ministerios.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Ministerio.Dtos;
using Empresa.Domain.Ministerio.Parameters;

namespace Empresa.Application.Ministerio.Mappers
{
    public class ListarMinisterioRequestMapper : IMapper<ListarMinisterioRequest, ListarMinisterioParameters>
    {
        public ListarMinisterioParameters Map(ListarMinisterioRequest source)
        {
            return new ListarMinisterioParameters
            {
            };
        }
    }
}
