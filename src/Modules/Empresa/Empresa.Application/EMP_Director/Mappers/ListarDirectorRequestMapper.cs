/*****
 * Nombre del archivo:  ListarDirectorRequestMapper.cs
 * Descripción:         Clase que mapea una solicitud de listado de directores sin paginación (`ListarDirectorRequest`) a los parámetros necesarios para la base de datos (`ListarDirectorParameters`).
 *                      Actualmente no contiene filtros ni propiedades adicionales, pero está diseñada para ser extendida si es necesario en el futuro.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Creación inicial de la clase.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Application.Director.Dtos;
using Empresa.Domain.Director.Parameters;

namespace Empresa.Application.Director.Mappers
{
    public class ListarDirectorRequestMapper : IMapper<ListarDirectorRequest, ListarDirectorParameters>
    {
        public ListarDirectorParameters Map(ListarDirectorRequest source)
        {
            return new ListarDirectorParameters 
            {
            };
        }
    }
}
