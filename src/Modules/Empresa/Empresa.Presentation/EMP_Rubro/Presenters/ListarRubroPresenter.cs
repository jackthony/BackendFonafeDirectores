using Empresa.Application.EMP_Rubro.Dtos;
using Empresa.Presentation.EMP_Rubro.Dtos.Request;
using Empresa.Presentation.EMP_Rubro.Dtos.Responses;
using Empresa.Presentation.EMP_Rubro.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Rubro.Presenters
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
