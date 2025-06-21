using Modulo.Application.Dtos;
using Modulo.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Modulo.Presentation.Presenters
{
    public class ActualizarModuloPresenter : IPresenter<
        ActualizarModuloClientRequest,
        ActualizarModuloRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public ActualizarModuloRequest ToRequest(ActualizarModuloClientRequest clientRequest)
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
