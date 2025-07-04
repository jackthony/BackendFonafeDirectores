using Shared.Kernel.Interfaces;
using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Mappers;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Presenters
{
    public class ListElementoResponsePresenter : IPresenterDelivery<List<ArchivoResult>, ListResponse<ElementoNodoResponse<ElementoDetalleResponse>>>
    {
        public ListResponse<ElementoNodoResponse<ElementoDetalleResponse>> Present(List<ArchivoResult> input)
        {
            return new ListResponse<ElementoNodoResponse<ElementoDetalleResponse>>
            {
                LstItem = ElementoResponseMapper.ToTree(input),
                IsSuccess = true
            };
        }
    }
}
