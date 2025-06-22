using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Empresa.Results;
using Empresa.Presentation.Empresa.Responses;

namespace Empresa.Presentation.Empresa.Mappers
{
    public class ListEmpresaResponsePresenter : IPresenterDelivery<List<EmpresaResult>, LstItemResponse<EmpresaResponse>>
    {
        public LstItemResponse<EmpresaResponse> Present(List<EmpresaResult> input)
        {
            return new LstItemResponse<EmpresaResponse>
            {
                LstItem = EmpresaResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
