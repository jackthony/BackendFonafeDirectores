using Director.Application.Dtos;
using Director.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Director.Presentation.Presenters
{
    public class ActualizarDirectorPresenter : IPresenter<
        ActualizarDirectorClientRequest,
        ActualizarDirectorRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public ActualizarDirectorRequest ToRequest(ActualizarDirectorClientRequest clientRequest)
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
