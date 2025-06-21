using Rol.Application.Dtos;
using Rol.Presentation.Dtos.Request;
using Rol.Presentation.Dtos.Responses;
using Rol.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rol.Presentation.Presenters
{
    public class ListarRolPaginadoPresenter : IPresenter<
        ListarRolPaginadoClientRequest,
        ListarRolPaginadoRequest,
        PagedResult<RolDto>,
        LstItemResponse<RolClientDto>>
    {
        public ListarRolPaginadoRequest ToRequest(ListarRolPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<RolClientDto> ToResponse(PagedResult<RolDto> dto)
        {
            return new LstItemResponse<RolClientDto>
            {
                LstItem = RolClientMapper.ToClientDtos(dto.Items),
                Pagination = new Pagination
                {
                    PageIndex = dto.Page,
                    PageSize = dto.PageSize,
                    TotalRows = dto.TotalItems
                },
                IsSuccess = true
            };
        }
    }
}
