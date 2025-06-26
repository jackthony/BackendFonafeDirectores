using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.PermisoRol.Results;
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
