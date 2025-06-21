using Rol.Application.Dtos;
using Rol.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rol.Presentation.Presenters
{
    public class ActualizarRolPresenter : IPresenter<
        ActualizarRolClientRequest,
        ActualizarRolRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public ActualizarRolRequest ToRequest(ActualizarRolClientRequest clientRequest)
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
