/*****
 * Nombre del archivo:  ListarEmpresaPaginadoRequestMapper.cs
 * Descripción:         Mapea un objeto de tipo ListarEmpresaPaginadoRequest a ListarEmpresaPaginadoParameters.
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación del mapeo entre la solicitud de paginación de empresas y sus parámetros correspondientes.
 *****/
using Shared.Kernel.Interfaces;
using Empresa.Application.Empresa.Dtos;
using Empresa.Domain.Empresa.Parameters;

namespace Empresa.Application.Empresa.Mappers
{
    public class ListarEmpresaPaginadoRequestMapper : IMapper<ListarEmpresaPaginadoRequest, ListarEmpresaPaginadoParameters>
    {
        public ListarEmpresaPaginadoParameters Map(ListarEmpresaPaginadoRequest source)
        {
            return new ListarEmpresaPaginadoParameters
            {
                Page = source.Page,
                PageSize = source.PageSize,
                RazonSocial = source.sRazonSocial,
                Estado = source.bEstado
            };
        }
    }
}
