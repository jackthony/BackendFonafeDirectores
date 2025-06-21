using Rol.Application.Dtos;
using Rol.Presentation.Dtos.Responses;
using Rol.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Rol.Presentation.Presenters
{
    public class ObtenerRolPorIdPresenter : IPresenter<
        int,
        long,
        RolDto,
        ItemResponse<RolClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<RolClientDto> ToResponse(RolDto dto)
        {
            return new ItemResponse<RolClientDto>
            {
                IsSuccess = true,
                Item = RolClientMapper.ToClientDto(dto),
            };
        }
    }
}
