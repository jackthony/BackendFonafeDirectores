/***********
* Nombre del archivo: ListarModuloPaginadoRequestMapper.cs
* Descripción:        **Implementación del mapeador** para transformar una **`ListarModuloPaginadoRequest`** (DTO de aplicación)
*                     a **`ListarModuloPaginadoParameters`** (parámetros de dominio). Este mapeador se encarga
*                     de convertir los datos de la solicitud de listar módulos paginados para que sean
*                     utilizables por la capa de dominio, incluyendo los criterios de paginación.
* Autor:              Daniel Alva
* Fecha de creación:  02/06/25
* Última modificación:02/06/25 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora para solicitudes de listado de módulos paginados.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.Modulo.Dtos;
using Usuario.Domain.Modulo.Parameters;

namespace Usuario.Application.Modulo.Mappers
{
    public class ListarModuloPaginadoRequestMapper : IMapper<ListarModuloPaginadoRequest, ListarModuloPaginadoParameters>
    {
        public ListarModuloPaginadoParameters Map(ListarModuloPaginadoRequest source)
        {
            return new ListarModuloPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
            };
        }
    }
}
