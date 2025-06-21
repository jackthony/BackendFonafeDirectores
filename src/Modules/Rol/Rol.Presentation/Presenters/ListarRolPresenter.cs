using Rol.Application.Dtos;
using Rol.Presentation.Dtos.Request;
using Rol.Presentation.Dtos.Responses;
using Rol.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Rol.Presentation.Presenters
{
    public class ListarRolPresenter : IPresenter<
        ListarRolClientRequest,
        ListarRolRequest,
        List<RolDto>,
        LstItemResponse<RolClientDto>>
    {
        public ListarRolRequest ToRequest(ListarRolClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<RolClientDto> ToResponse(List<RolDto> dto)
        {
            return new LstItemResponse<RolClientDto>
            {
                LstItem = RolClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
