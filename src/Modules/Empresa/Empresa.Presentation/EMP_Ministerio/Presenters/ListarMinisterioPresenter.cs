using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Presentation.EMP_Ministerio.Dtos.Request;
using Empresa.Presentation.EMP_Ministerio.Dtos.Responses;
using Empresa.Presentation.EMP_Ministerio.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Ministerio.Presenters
{
    public class ListarMinisterioPresenter : IPresenter<
    ListarMinisterioClientRequest,
    ListarMinisterioRequest,
    List<MinisterioDto>,
    LstItemResponse<MinisterioClientDto>>
    {
        public ListarMinisterioRequest ToRequest(ListarMinisterioClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<MinisterioClientDto> ToResponse(List<MinisterioDto> dto)
        {
            return new LstItemResponse<MinisterioClientDto>
            {
                LstItem = MinisterioClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
