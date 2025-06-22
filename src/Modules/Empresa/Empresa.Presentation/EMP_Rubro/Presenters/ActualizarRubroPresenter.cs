using Empresa.Application.EMP_Rubro.Dtos;
using Empresa.Presentation.EMP_Rubro.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Rubro.Presenters
{
    public class ActualizarRubroPresenter : IPresenter<
    ActualizarRubroClientRequest,
    ActualizarRubroRequest,
    SpResultBase,
    ItemResponse<bool>>
    {
        public ActualizarRubroRequest ToRequest(ActualizarRubroClientRequest clientRequest)
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
