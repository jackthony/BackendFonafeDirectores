/*****
 * Nombre del archivo:  ListarTipoDirectorRequestMapper.cs
 * Descripción:         Mapeador que transforma un objeto ListarTipoDirectorRequest en 
 *                      ListarTipoDirectorParameters para su uso en el caso de uso correspondiente.
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
    public class ListarTipoDirectorRequestMapper : IMapper<ListarTipoDirectorRequest, ListarTipoDirectorParameters>
    {
        public ListarTipoDirectorParameters Map(ListarTipoDirectorRequest source)
        {
            return new ListarTipoDirectorParameters
            {
            };
        }
    }
}
