using Accion.Application.Dtos;
using Accion.Presentation.Dtos.Request;
using Accion.Presentation.Dtos.Responses;
using Accion.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Accion.Presentation.Presenters
{
    public class ListarAccionPresenter : IPresenter<
        ListarAccionClientRequest,
        ListarAccionRequest,
        List<AccionDto>,
        LstItemResponse<AccionClientDto>>
    {
        public ListarAccionRequest ToRequest(ListarAccionClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<AccionClientDto> ToResponse(List<AccionDto> dto)
        {
            return new LstItemResponse<AccionClientDto>
            {
                LstItem = AccionClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
