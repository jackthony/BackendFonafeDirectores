using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.Rol.Results;
using Usuario.Presentation.Rol.Responses;

namespace Usuario.Presentation.Rol.Mappers
{
    public class ListRolResponsePresenter : IPresenterDelivery<List<RolResult>, LstItemResponse<RolResponse>>
    {
        public LstItemResponse<RolResponse> Present(List<RolResult> input)
        {
            return new LstItemResponse<RolResponse>
            {
                LstItem = RolResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
