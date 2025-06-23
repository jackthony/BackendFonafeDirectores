using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Usuario.Domain.PermisoRol.Results;
using Usuario.Presentation.PermisoRol.Responses;

namespace Usuario.Presentation.PermisoRol.Mappers
{
    public class ObtenerPermisoRolResponsePorIdPresenter : IPresenterDelivery<PermisoRolResult, ItemResponse<PermisoRolResponse>>
    {
        public ItemResponse<PermisoRolResponse> Present(PermisoRolResult input)
        {
            return new ItemResponse<PermisoRolResponse>
            {
                IsSuccess = true,
                Item = PermisoRolResponseMapper.ToResponse(input),
            };
        }
    }
}
