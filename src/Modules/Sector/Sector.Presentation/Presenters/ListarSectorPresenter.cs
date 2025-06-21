using Sector.Application.Dtos;
using Sector.Presentation.Dtos.Request;
using Sector.Presentation.Dtos.Responses;
using Sector.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Sector.Presentation.Presenters
{
    public class ListarSectorPresenter : IPresenter<
        ListarSectorClientRequest,
        ListarSectorRequest,
        List<SectorDto>,
        LstItemResponse<SectorClientDto>>
    {
        public ListarSectorRequest ToRequest(ListarSectorClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<SectorClientDto> ToResponse(List<SectorDto> dto)
        {
            return new LstItemResponse<SectorClientDto>
            {
                LstItem = SectorClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
