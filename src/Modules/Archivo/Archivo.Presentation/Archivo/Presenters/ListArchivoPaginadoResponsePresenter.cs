using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;
using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Mappers;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Presenters
{
    public class ListArchivoPaginadoResponsePresenter : IPresenterDelivery<PagedResult<ArchivoResult>, LstItemResponse<ArchivoResponse>>
    {
        public LstItemResponse<ArchivoResponse> Present(PagedResult<ArchivoResult> input)
        {
            return new LstItemResponse<ArchivoResponse>
            {
                LstItem = ArchivoResponseMapper.ToListResponse(input.Items),
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
