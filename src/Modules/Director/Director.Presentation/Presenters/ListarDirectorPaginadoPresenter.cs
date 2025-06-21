using Director.Application.Dtos;
using Director.Presentation.Dtos.Request;
using Director.Presentation.Dtos.Responses;
using Director.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Director.Presentation.Presenters
{
    public class ListarDirectorPaginadoPresenter : IPresenter<
        ListarDirectorPaginadoClientRequest,
        ListarDirectorPaginadoRequest,
        PagedResult<DirectorDto>,
        LstItemResponse<DirectorClientDto>>
    {
        public ListarDirectorPaginadoRequest ToRequest(ListarDirectorPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<DirectorClientDto> ToResponse(PagedResult<DirectorDto> dto)
        {
            return new LstItemResponse<DirectorClientDto>
            {
                LstItem = DirectorClientMapper.ToClientDtos(dto.Items),
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
