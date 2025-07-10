using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.PermisoRol.Results;
/***********
 * Nombre del archivo:  ListPermisoRolPaginadoResponsePresenter.cs
 * Descripción:         Presentador encargado de transformar una lista paginada de resultados 
 *                      de permisos por rol en una respuesta estandarizada para el cliente.
 * 
 * Autor:               Daniel Alva
 * Fecha de creación:   10/07/2025
 * Última modificación: 10/07/2025 por Daniel Alva
 * Cambios recientes:   Implementación del presentador para respuesta paginada de permisos por rol.
 ***********/

using Usuario.Presentation.PermisoRol.Mappers;
using Usuario.Presentation.PermisoRol.Responses;

namespace Usuario.Presentation.PermisoRol.Presenters
{
    public class ListPermisoRolPaginadoResponsePresenter : IPresenterDelivery<PagedResult<PermisoRolResult>, LstItemResponse<PermisoRolResponse>>
    {
        public LstItemResponse<PermisoRolResponse> Present(PagedResult<PermisoRolResult> input)
        {
            return new LstItemResponse<PermisoRolResponse>
            {
                LstItem = PermisoRolResponseMapper.ToListResponse(input.Items),
                Pagination = new Pagination
                {
                    PageIndex = input.Page,
                    PageSize = input.PageSize,
                    TotalRows = input.TotalItems
                },
                IsSuccess = true
            };
        }
    }
}
