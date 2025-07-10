/*****
 * Nombre del archivo:  ListarDepartamentoRequestMapper.cs
 * Descripción:         Mapeador que convierte un objeto ListarDepartamentoRequest en 
 *                      ListarDepartamentoParameters, utilizado por el caso de uso para listar departamentos.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/

using Empresa.Application.Ubigeo.Dtos;
using Empresa.Domain.Ubigeo.Parameters;
using Shared.Kernel.Interfaces;

namespace Empresa.Application.Departamento.Mappers
{
    public class ListarDepartamentoRequestMapper : IMapper<ListarDepartamentoRequest, ListarDepartamentoParameters>
    {
        public ListarDepartamentoParameters Map(ListarDepartamentoRequest source)
        {
            return new ListarDepartamentoParameters
            {
                Nombre = source.sNombre,
            };
        }
    }
}
