using Accion.Application.Dtos;
using Accion.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Accion.Presentation.Presenters
{
    public class CrearAccionPresenter : IPresenter<
        CrearAccionClientRequest,
        CrearAccionRequest,
        SpResultBase,
        ItemResponse<int>>
    {
        public CrearAccionRequest ToRequest(CrearAccionClientRequest clientRequest)
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
