using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Presentation.EMP_Ministerio.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Ministerio.Presenters
{
    public class ActualizarMinisterioPresenter : IPresenter<
    ActualizarMinisterioClientRequest,
    ActualizarMinisterioRequest,
    SpResultBase,
    ItemResponse<bool>>
    {
        public ActualizarMinisterioRequest ToRequest(ActualizarMinisterioClientRequest clientRequest)
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
