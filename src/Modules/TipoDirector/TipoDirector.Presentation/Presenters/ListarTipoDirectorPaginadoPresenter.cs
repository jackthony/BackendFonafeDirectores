using TipoDirector.Application.Dtos;
using TipoDirector.Presentation.Dtos.Request;
using TipoDirector.Presentation.Dtos.Responses;
using TipoDirector.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace TipoDirector.Presentation.Presenters
{
    public class ListarTipoDirectorPaginadoPresenter : IPresenter<
        ListarTipoDirectorPaginadoClientRequest,
        ListarTipoDirectorPaginadoRequest,
        PagedResult<TipoDirectorDto>,
        LstItemResponse<TipoDirectorClientDto>>
    {
        public ListarTipoDirectorPaginadoRequest ToRequest(ListarTipoDirectorPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<TipoDirectorClientDto> ToResponse(PagedResult<TipoDirectorDto> dto)
        {
            return new LstItemResponse<TipoDirectorClientDto>
            {
                LstItem = TipoDirectorClientMapper.ToClientDtos(dto.Items),
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
