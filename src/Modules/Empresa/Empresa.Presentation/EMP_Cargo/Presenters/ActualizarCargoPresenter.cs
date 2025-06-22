using Empresa.Application.EMP_Cargo.Dtos;
using Empresa.Presentation.EMP_Cargo.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Cargo.Presenters
{
    public class ActualizarCargoPresenter : IPresenter<
    ActualizarCargoClientRequest,
    ActualizarCargoRequest,
    SpResultBase,
    ItemResponse<bool>>
    {
        public ActualizarCargoRequest ToRequest(ActualizarCargoClientRequest clientRequest)
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
