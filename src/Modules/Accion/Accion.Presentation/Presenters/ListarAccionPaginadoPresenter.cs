using Accion.Application.Dtos;
using Accion.Presentation.Dtos.Request;
using Accion.Presentation.Dtos.Responses;
using Accion.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Accion.Presentation.Presenters
{
    public class ListarAccionPaginadoPresenter : IPresenter<
        ListarAccionPaginadoClientRequest,
        ListarAccionPaginadoRequest,
        PagedResult<AccionDto>,
        LstItemResponse<AccionClientDto>>
    {
        public ListarAccionPaginadoRequest ToRequest(ListarAccionPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<AccionClientDto> ToResponse(PagedResult<AccionDto> dto)
        {
            return new LstItemResponse<AccionClientDto>
            {
                LstItem = AccionClientMapper.ToClientDtos(dto.Items),
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
