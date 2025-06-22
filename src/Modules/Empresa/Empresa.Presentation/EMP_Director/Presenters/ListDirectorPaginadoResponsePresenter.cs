using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Director.Results;
using Empresa.Presentation.Director.Mappers;
using Empresa.Presentation.Director.Responses;

namespace Empresa.Presentation.Director.Presenters
{
    public class ListDirectorPaginadoResponsePresenter : IPresenterDelivery<PagedResult<DirectorResult>, LstItemResponse<DirectorResponse>>
    {
        public LstItemResponse<DirectorResponse> Present(PagedResult<DirectorResult> input)
        {
            return new LstItemResponse<DirectorResponse>
            {
                LstItem = DirectorResponseMapper.ToListResponse(input.Items),
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
