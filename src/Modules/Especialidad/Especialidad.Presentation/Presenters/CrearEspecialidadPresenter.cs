using Especialidad.Application.Dtos;
using Especialidad.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Especialidad.Presentation.Presenters
{
    public class CrearEspecialidadPresenter : IPresenter<
        CrearEspecialidadClientRequest,
        CrearEspecialidadRequest,
        SpResultBase,
        ItemResponse<int>>
    {
        public CrearEspecialidadRequest ToRequest(CrearEspecialidadClientRequest clientRequest)
        {
            throw new NotImplementedException();
        }

        public ItemResponse<int> ToResponse(SpResultBase dto)
        {
            return new ItemResponse<int>
            {
                IsSuccess = dto.Success,
                Item = (int)dto.Data,
                LstError = dto.Success
            ? []
            : [dto.Message ?? "Ocurrió un error al procesar la solicitud"]
            };
        }
    }
}
