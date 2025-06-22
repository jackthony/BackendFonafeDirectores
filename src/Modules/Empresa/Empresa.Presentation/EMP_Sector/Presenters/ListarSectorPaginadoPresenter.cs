using Empresa.Application.EMP_Sector.Dtos;
using Empresa.Presentation.EMP_Sector.Dtos.Request;
using Empresa.Presentation.EMP_Sector.Dtos.Responses;
using Empresa.Presentation.EMP_Sector.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Sector.Presenters
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
