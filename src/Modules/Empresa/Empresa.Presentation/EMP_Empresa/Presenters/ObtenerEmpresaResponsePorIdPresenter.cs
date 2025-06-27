using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Empresa.Results;
using Empresa.Presentation.Empresa.Responses;

namespace Empresa.Presentation.Empresa.Mappers
{
    public class ObtenerEmpresaResponsePorIdPresenter : IPresenterDelivery<EmpresaResult, ItemResponse<EmpresaResponse>>
    {
        public ItemResponse<EmpresaResponse> Present(EmpresaResult input)
        {
            return new ItemResponse<EmpresaResponse>
            {
                IsSuccess = true,
                Item = EmpresaResponseMapper.ToResponse(input),
            };
        }
    }
}
