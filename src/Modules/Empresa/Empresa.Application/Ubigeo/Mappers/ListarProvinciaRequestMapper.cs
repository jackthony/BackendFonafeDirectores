/*****
 * Nombre del archivo:  ListarProvinciaRequestMapper.cs
 * Descripción:         Mapeador que convierte un objeto ListarProvinciaRequest en los parámetros
 *                      de dominio ListarProvinciaParameters para su uso en el caso de uso correspondiente.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Provincia.Mappers
{
    public class ListarProvinciaRequestMapper : IMapper<ListarProvinciaRequest, ListarProvinciaParameters>
    {
        public ListarProvinciaParameters Map(ListarProvinciaRequest source)
        {
            return new ListarProvinciaParameters
            {
                DepartamentoId = int.Parse(source.sCode),
                Nombre = source.sNombre
            };
        }
    }
}
