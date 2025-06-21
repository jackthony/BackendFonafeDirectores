using Rubro.Application.Dtos;
using Rubro.Presentation.Dtos.Request;
using Rubro.Presentation.Dtos.Responses;
using Rubro.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Rubro.Presentation.Presenters
{
    public class ListarRubroPresenter : IPresenter<
        ListarRubroClientRequest,
        ListarRubroRequest,
        List<RubroDto>,
        LstItemResponse<RubroClientDto>>
    {
        public ListarRubroRequest ToRequest(ListarRubroClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<RubroClientDto> ToResponse(List<RubroDto> dto)
        {
            return new LstItemResponse<RubroClientDto>
            {
                LstItem = RubroClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
