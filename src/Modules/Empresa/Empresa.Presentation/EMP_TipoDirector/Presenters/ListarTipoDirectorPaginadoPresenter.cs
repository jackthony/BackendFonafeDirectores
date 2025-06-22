using Empresa.Application.EMP_TipoDirector.Dtos;
using Empresa.Presentation.EMP_TipoDirector.Dtos.Request;
using Empresa.Presentation.EMP_TipoDirector.Dtos.Responses;
using Empresa.Presentation.EMP_TipoDirector.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_TipoDirector.Presenters
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
