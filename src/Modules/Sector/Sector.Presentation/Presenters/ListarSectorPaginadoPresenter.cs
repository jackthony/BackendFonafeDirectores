using Sector.Application.Dtos;
using Sector.Presentation.Dtos.Request;
using Sector.Presentation.Dtos.Responses;
using Sector.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Sector.Presentation.Presenters
{
    public class ListarSectorPaginadoPresenter : IPresenter<
        ListarSectorPaginadoClientRequest,
        ListarSectorPaginadoRequest,
        PagedResult<SectorDto>,
        LstItemResponse<SectorClientDto>>
    {
        public ListarSectorPaginadoRequest ToRequest(ListarSectorPaginadoClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<SectorClientDto> ToResponse(PagedResult<SectorDto> dto)
        {
            return new LstItemResponse<SectorClientDto>
            {
                LstItem = SectorClientMapper.ToClientDtos(dto.Items),
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
