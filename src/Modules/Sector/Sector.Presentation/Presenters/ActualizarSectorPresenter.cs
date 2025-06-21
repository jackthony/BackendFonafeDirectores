using Sector.Application.Dtos;
using Sector.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Sector.Presentation.Presenters
{
    public class ActualizarSectorPresenter : IPresenter<
        ActualizarSectorClientRequest,
        ActualizarSectorRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public ActualizarSectorRequest ToRequest(ActualizarSectorClientRequest clientRequest)
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
