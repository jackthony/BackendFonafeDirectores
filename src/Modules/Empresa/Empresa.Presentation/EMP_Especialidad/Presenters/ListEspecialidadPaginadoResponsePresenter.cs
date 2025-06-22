using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Mappers;
using Empresa.Presentation.Especialidad.Responses;

namespace Empresa.Presentation.Especialidad.Presenters
{
    public class ListEspecialidadPaginadoResponsePresenter : IPresenterDelivery<PagedResult<EspecialidadResult>, LstItemResponse<EspecialidadResponse>>
    {
        public LstItemResponse<EspecialidadResponse> Present(PagedResult<EspecialidadResult> input)
        {
            return new LstItemResponse<EspecialidadResponse>
            {
                LstItem = EspecialidadResponseMapper.ToListResponse(input.Items),
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
