/***********
* Nombre del archivo: ListarPermisoRolPaginadoRequestMapper.cs
* Descripción:        **Implementación del mapeador** para transformar una **`ListarPermisoRolPaginadoRequest`** (DTO de aplicación)
*                     a **`ListarPermisoRolPaginadoParameters`** (parámetros de dominio). Este mapeador se encarga
*                     de convertir los datos de la solicitud de listar permisos de rol con paginación para que sean
*                     utilizables por la capa de dominio. Actualmente, se inicializa sin mapeo de propiedades,
*                     lo que implica que los parámetros de paginación se manejarán de otra forma o que este mapper
*                     se usará para una solicitud de paginación básica sin filtros adicionales.
* Autor:              Daniel Alva
* Fecha de creación:  11/07/2025
* Última modificación:11/07/2025 por Daniel Alva
* Cambios recientes:  Creación inicial de la clase mapeadora.
***********/

using Shared.Kernel.Interfaces;
using Usuario.Application.PermisoRol.Dtos;
using Usuario.Domain.PermisoRol.Parameters;

namespace Usuario.Application.PermisoRol.Mappers
{
    public class ListarPermisoRolPaginadoRequestMapper : IMapper<ListarPermisoRolPaginadoRequest, ListarPermisoRolPaginadoParameters>
    {
        public ListarPermisoRolPaginadoParameters Map(ListarPermisoRolPaginadoRequest source)
        {
            return new ListarPermisoRolPaginadoParameters
            {
            };
        }
    }
}
