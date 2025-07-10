/*****
 * Nombre de clase:     ListarRubroRequestMapper
 * Descripción:         Mapper encargado de transformar el DTO ListarRubroRequest
 *                      en el parámetro ListarRubroParameters utilizado en la capa de dominio.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Clase creada para realizar el mapeo entre el request de aplicación y los parámetros de dominio.
 *****/

using Shared.Kernel.Interfaces;
using Empresa.Application.Rubro.Dtos;
using Empresa.Domain.Rubro.Parameters;

namespace Empresa.Application.Rubro.Mappers
{
    public class ListarRubroRequestMapper : IMapper<ListarRubroRequest, ListarRubroParameters>
    {
        public ListarRubroParameters Map(ListarRubroRequest source)
        {
            return new ListarRubroParameters
            {
            };
        }
    }
}
