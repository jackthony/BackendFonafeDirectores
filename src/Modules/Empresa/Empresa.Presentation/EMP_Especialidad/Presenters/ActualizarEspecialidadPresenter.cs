using Empresa.Application.EMP_Especialidad.Dtos;
using Empresa.Presentation.EMP_Especialidad.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Especialidad.Presenters
{
    public class ActualizarEspecialidadPresenter : IPresenter<
    ActualizarEspecialidadClientRequest,
    ActualizarEspecialidadRequest,
    SpResultBase,
    ItemResponse<bool>>
    {
        public ActualizarEspecialidadRequest ToRequest(ActualizarEspecialidadClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<bool> ToResponse(SpResultBase dto)
        {
            return new ItemResponse<bool>
            {
                IsSuccess = dto.Success,
                Item = dto.Success,
                LstError = dto.Success
            ? []
            : [dto.Message ?? "Ocurrió un error al procesar la solicitud"]
            };
        }
    }
}
