using Empresa.Application.EMP_Sector.Dtos;
using Empresa.Presentation.EMP_Sector.Dtos.Request;
using Empresa.Presentation.EMP_Sector.Dtos.Responses;
using Empresa.Presentation.EMP_Sector.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Sector.Presenters
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
