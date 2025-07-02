using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Archivo.Domain.Archivo.Results;
using Archivo.Presentation.Archivo.Mappers;
using Archivo.Presentation.Archivo.Responses;

namespace Archivo.Presentation.Archivo.Presenters
{
    public class ListArchivoResponsePresenter : IPresenterDelivery<List<ArchivoResult>, TreeResponse<ArchivoNode>>
    {
        public TreeResponse<ArchivoNode> Present(List<ArchivoResult> input)
        {
            return new TreeResponse<ArchivoNode>
            {
                LstItem = ArchivoResponseMapper.ToTree(input),
                IsSuccess = true
            };
        }
    }
}
