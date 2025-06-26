using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.PermisoRol.Results;
using Usuario.Presentation.PermisoRol.Responses;

namespace Usuario.Presentation.PermisoRol.Mappers
{
    public class ListPermisoRolResponsePresenter : IPresenterDelivery<List<PermisoRolResult>, LstItemResponse<PermisoRolResponse>>
    {
        public LstItemResponse<PermisoRolResponse> Present(List<PermisoRolResult> input)
        {
            return new LstItemResponse<PermisoRolResponse>
            {
                LstItem = PermisoRolResponseMapper.ToListResponse(input),
                IsSuccess = true
            };
        }
    }
}
