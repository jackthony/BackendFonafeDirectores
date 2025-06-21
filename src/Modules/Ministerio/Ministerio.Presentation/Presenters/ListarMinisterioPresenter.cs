using Ministerio.Application.Dtos;
using Ministerio.Presentation.Dtos.Request;
using Ministerio.Presentation.Dtos.Responses;
using Ministerio.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Ministerio.Presentation.Presenters
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
