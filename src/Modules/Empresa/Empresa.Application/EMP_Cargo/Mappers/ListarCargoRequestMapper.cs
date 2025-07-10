/*****
 * Nombre del archivo:  ListarCargoRequestMapper.cs
 * Descripción:         Clase encargada de mapear una solicitud de listado de cargos (`ListarCargoRequest`) a los parámetros necesarios para realizar la consulta de cargos en la base de datos (`ListarCargoParameters`).
 *                      Actualmente no tiene lógica de mapeo, pero está diseñada para ser extendida en el futuro con los parámetros necesarios para la consulta.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Application.Cargo.Dtos;
using Empresa.Domain.Cargo.Parameters;

namespace Empresa.Application.Cargo.Mappers
{
    public class ListarCargoRequestMapper : IMapper<ListarCargoRequest, ListarCargoParameters>
    {
        public ListarCargoParameters Map(ListarCargoRequest source)
        {
            return new ListarCargoParameters 
            {
            };
        }
    }
}
