using Usuario.Application.Dtos;
using Usuario.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Usuario.Presentation.Presenters
{
    public class ActualizarUsuarioPresenter : IPresenter<
        ActualizarUsuarioClientRequest,
        ActualizarUsuarioRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public ActualizarUsuarioRequest ToRequest(ActualizarUsuarioClientRequest clientRequest)
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
