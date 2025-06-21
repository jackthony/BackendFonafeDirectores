using Modulo.Application.Dtos;
using Modulo.Presentation.Dtos.Request;
using Modulo.Presentation.Dtos.Responses;
using Modulo.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Modulo.Presentation.Presenters
{
    public class ListarModuloPaginadoPresenter : IPresenter<
        ListarModuloPaginadoClientRequest,
        ListarModuloPaginadoRequest,
        PagedResult<ModuloDto>,
        LstItemResponse<ModuloClientDto>>
    {
        public ListarModuloPaginadoRequest ToRequest(ListarModuloPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<ModuloClientDto> ToResponse(PagedResult<ModuloDto> dto)
        {
            return new LstItemResponse<ModuloClientDto>
            {
                LstItem = ModuloClientMapper.ToClientDtos(dto.Items),
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
