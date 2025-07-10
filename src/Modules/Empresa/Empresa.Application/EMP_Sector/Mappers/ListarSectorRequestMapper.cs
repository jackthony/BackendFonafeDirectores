/*****
 * Nombre del archivo:  ListarSectorRequestMapper.cs
 * Descripción:         Mapeador que convierte un objeto ListarSectorRequest en ListarSectorParameters.
 *                      Actualmente no realiza mapeo de propiedades, pero está preparado para extenderse.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Sector.Dtos;
using Empresa.Domain.Sector.Parameters;

namespace Empresa.Application.Sector.Mappers
{
    public class ListarSectorRequestMapper : IMapper<ListarSectorRequest, ListarSectorParameters>
    {
        public ListarSectorParameters Map(ListarSectorRequest source)
        {
            return new ListarSectorParameters
            {
            };
        }
    }
}
