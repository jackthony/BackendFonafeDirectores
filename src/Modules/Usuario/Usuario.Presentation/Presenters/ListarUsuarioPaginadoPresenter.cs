using Usuario.Application.Dtos;
using Usuario.Presentation.Dtos.Request;
using Usuario.Presentation.Dtos.Responses;
using Usuario.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Usuario.Presentation.Presenters
{
    public class ListarUsuarioPaginadoPresenter : IPresenter<
        ListarUsuarioPaginadoClientRequest,
        ListarUsuarioPaginadoRequest,
        PagedResult<UsuarioDto>,
        LstItemResponse<UsuarioClientDto>>
    {
        public ListarUsuarioPaginadoRequest ToRequest(ListarUsuarioPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<UsuarioClientDto> ToResponse(PagedResult<UsuarioDto> dto)
        {
            return new LstItemResponse<UsuarioClientDto>
            {
                LstItem = UsuarioClientMapper.ToClientDtos(dto.Items),
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
