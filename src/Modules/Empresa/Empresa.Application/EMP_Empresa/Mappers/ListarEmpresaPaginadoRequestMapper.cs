/*****
 * Nombre del archivo:  ListarEmpresaPaginadoRequestMapper.cs
 * Descripción:         Mapea un objeto de tipo ListarEmpresaPaginadoRequest a ListarEmpresaPaginadoParameters.
 * Autor:               Daniel Alva
 * Fecha de creación:   02/06/25
 * Última modificación: 02/06/25 por Daniel Alva
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
                Estado = source.bEstado,
                FechaIncio = source.dtFechaInicio,
                FechaFin = source.dtFechaFin,
            };
        }
    }
}
