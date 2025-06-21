using Sector.Application.Dtos;
using Sector.Presentation.Dtos.Responses;
using Sector.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Sector.Presentation.Presenters
{
    public class ObtenerSectorPorIdPresenter : IPresenter<
        int,
        long,
        SectorDto,
        ItemResponse<SectorClientDto>>
    {
        public long ToRequest(int clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<SectorClientDto> ToResponse(SectorDto dto)
        {
            return new ItemResponse<SectorClientDto>
            {
                IsSuccess = true,
                Item = SectorClientMapper.ToClientDto(dto),
            };
        }
    }
}
