using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Rol.Results;
using Usuario.Presentation.Rol.Responses;

namespace Usuario.Presentation.Rol.Mappers
{
    public class ObtenerRolResponsePorIdPresenter : IPresenterDelivery<RolResult, ItemResponse<RolResponse>>
    {
        public ItemResponse<RolResponse> Present(RolResult input)
        {
            return new ItemResponse<RolResponse>
            {
                IsSuccess = true,
                Item = RolResponseMapper.ToResponse(input),
            };
        }
    }
}
