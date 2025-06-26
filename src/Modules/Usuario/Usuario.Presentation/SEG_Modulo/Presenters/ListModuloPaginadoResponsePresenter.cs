using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Usuario.Domain.Modulo.Results;
using Usuario.Presentation.Modulo.Mappers;
using Usuario.Presentation.Modulo.Responses;

namespace Usuario.Presentation.Modulo.Presenters
{
    public class ListModuloPaginadoResponsePresenter : IPresenterDelivery<PagedResult<ModuloResult>, LstItemResponse<ModuloResponse>>
    {
        public LstItemResponse<ModuloResponse> Present(PagedResult<ModuloResult> input)
        {
            return new LstItemResponse<ModuloResponse>
            {
                LstItem = ModuloResponseMapper.ToListResponse(input.Items),
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
