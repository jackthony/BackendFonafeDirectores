/*****
 * Nombre del archivo:  ListarDistritoRequestMapper.cs
 * Descripción:         Mapeador encargado de transformar un objeto ListarDistritoRequest en
 *                      ListarDistritoParameters, que será utilizado en el dominio para listar distritos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Distrito.Mappers
{
    public class ListarDistritoRequestMapper : IMapper<ListarDistritoRequest, ListarDistritoParameters>
    {
        public ListarDistritoParameters Map(ListarDistritoRequest source)
        {
            return new ListarDistritoParameters
            {
                Nombre = source.sNombre,
                ProvinciaId = int.Parse(source.sCode)
            };
        }
    }
}
