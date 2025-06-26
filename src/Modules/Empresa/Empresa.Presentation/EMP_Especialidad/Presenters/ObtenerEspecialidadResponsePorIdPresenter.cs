using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Empresa.Domain.Especialidad.Results;
using Empresa.Presentation.Especialidad.Responses;

namespace Empresa.Presentation.Especialidad.Mappers
{
    public class ObtenerEspecialidadResponsePorIdPresenter : IPresenterDelivery<EspecialidadResult, ItemResponse<EspecialidadResponse>>
    {
        public ItemResponse<EspecialidadResponse> Present(EspecialidadResult input)
        {
            return new ItemResponse<EspecialidadResponse>
            {
                IsSuccess = true,
                Item = EspecialidadResponseMapper.ToResponse(input),
            };
        }
    }
}
