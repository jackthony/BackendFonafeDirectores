using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Presentation.EMP_Ministerio.Dtos.Request;
using Empresa.Presentation.EMP_Ministerio.Dtos.Responses;
using Empresa.Presentation.EMP_Ministerio.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Ministerio.Presenters
{
    public class ListarMinisterioPaginadoPresenter : IPresenter<
    ListarMinisterioPaginadoClientRequest,
    ListarMinisterioPaginadoRequest,
    PagedResult<MinisterioDto>,
    LstItemResponse<MinisterioClientDto>>
    {
        public ListarMinisterioPaginadoRequest ToRequest(ListarMinisterioPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<MinisterioClientDto> ToResponse(PagedResult<MinisterioDto> dto)
        {
            return new LstItemResponse<MinisterioClientDto>
            {
                LstItem = MinisterioClientMapper.ToClientDtos(dto.Items),
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
