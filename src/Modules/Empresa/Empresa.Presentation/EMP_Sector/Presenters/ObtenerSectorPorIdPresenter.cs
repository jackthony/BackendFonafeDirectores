using Empresa.Application.EMP_Sector.Dtos;
using Empresa.Presentation.EMP_Sector.Dtos.Responses;
using Empresa.Presentation.EMP_Sector.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Sector.Presenters
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
