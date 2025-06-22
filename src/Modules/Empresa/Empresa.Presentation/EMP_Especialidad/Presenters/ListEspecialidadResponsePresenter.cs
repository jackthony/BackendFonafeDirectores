using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Responses;

namespace Empresa.Presentation.Especialidad.Mappers
{
    public class ListEspecialidadResponsePresenter : IPresenterDelivery<List<EspecialidadResult>, LstItemResponse<EspecialidadResponse>>
    {
        public LstItemResponse<EspecialidadResponse> Present(List<EspecialidadResult> input)
        {
            return new LstItemResponse<EspecialidadResponse>
            {
                LstItem = EspecialidadResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
