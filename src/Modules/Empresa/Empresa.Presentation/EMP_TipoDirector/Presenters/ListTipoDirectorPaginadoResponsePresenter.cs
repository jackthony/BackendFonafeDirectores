using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.TipoDirector.Results;
using Empresa.Presentation.TipoDirector.Mappers;
using Empresa.Presentation.TipoDirector.Responses;

namespace Empresa.Presentation.TipoDirector.Presenters
{
    public class ListTipoDirectorPaginadoResponsePresenter : IPresenterDelivery<PagedResult<TipoDirectorResult>, LstItemResponse<TipoDirectorResponse>>
    {
        public LstItemResponse<TipoDirectorResponse> Present(PagedResult<TipoDirectorResult> input)
        {
            return new LstItemResponse<TipoDirectorResponse>
            {
                LstItem = TipoDirectorResponseMapper.ToListResponse(input.Items),
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
