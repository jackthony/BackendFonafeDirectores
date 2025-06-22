using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Presentation.EMP_Especialidad.Dtos.Request;
using Empresa.Presentation.EMP_Especialidad.Dtos.Responses;
using Empresa.Presentation.EMP_Especialidad.Mappers;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;

namespace Empresa.Presentation.EMP_Especialidad.Presenters
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
