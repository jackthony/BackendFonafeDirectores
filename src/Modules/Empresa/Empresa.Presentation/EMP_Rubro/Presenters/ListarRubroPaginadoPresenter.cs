using Empresa.Application.EMP_Rubro.Dtos;
using Empresa.Presentation.EMP_Rubro.Dtos.Request;
using Empresa.Presentation.EMP_Rubro.Dtos.Responses;
using Empresa.Presentation.EMP_Rubro.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Rubro.Presenters
{
    public class ListarRubroPaginadoPresenter : IPresenter<
    ListarRubroPaginadoClientRequest,
    ListarRubroPaginadoRequest,
    PagedResult<RubroDto>,
    LstItemResponse<RubroClientDto>>
    {
        public ListarRubroPaginadoRequest ToRequest(ListarRubroPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<RubroClientDto> ToResponse(PagedResult<RubroDto> dto)
        {
            return new LstItemResponse<RubroClientDto>
            {
                LstItem = RubroClientMapper.ToClientDtos(dto.Items),
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
