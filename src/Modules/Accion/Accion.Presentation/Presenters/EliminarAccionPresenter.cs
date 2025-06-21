using Accion.Application.Dtos;
using Accion.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Accion.Presentation.Presenters
{
    public class EliminarAccionPresenter : IPresenter<
        EliminarAccionClientRequest,
        EliminarAccionRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public EliminarAccionRequest ToRequest(EliminarAccionClientRequest clientRequest)
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
