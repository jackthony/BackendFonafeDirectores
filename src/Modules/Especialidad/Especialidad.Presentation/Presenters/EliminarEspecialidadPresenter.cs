using Especialidad.Application.Dtos;
using Especialidad.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Especialidad.Presentation.Presenters
{
    public class EliminarEspecialidadPresenter : IPresenter<
        EliminarEspecialidadClientRequest,
        EliminarEspecialidadRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public EliminarEspecialidadRequest ToRequest(EliminarEspecialidadClientRequest clientRequest)
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
