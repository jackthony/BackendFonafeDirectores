using Especialidad.Application.Dtos;
using Especialidad.Presentation.Dtos.Request;
using Especialidad.Presentation.Dtos.Responses;
using Especialidad.Presentation.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Especialidad.Presentation.Presenters
{
    public class ListarEspecialidadPresenter : IPresenter<
        ListarEspecialidadClientRequest,
        ListarEspecialidadRequest,
        List<EspecialidadDto>,
        LstItemResponse<EspecialidadClientDto>>
    {
        public ListarEspecialidadRequest ToRequest(ListarEspecialidadClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public LstItemResponse<EspecialidadClientDto> ToResponse(List<EspecialidadDto> dto)
        {
            return new LstItemResponse<EspecialidadClientDto>
            {
                LstItem = EspecialidadClientMapper.ToClientDtos(dto),
                IsSuccess = true
            };
        }
    }
}
