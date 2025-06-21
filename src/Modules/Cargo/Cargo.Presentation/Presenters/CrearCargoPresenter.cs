using Cargo.Application.Dtos;
using Cargo.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Cargo.Presentation.Presenters
{
    public class CrearCargoPresenter : IPresenter<
        CrearCargoClientRequest,
        CrearCargoRequest,
        SpResultBase,
        ItemResponse<int>>
    {
        public CrearCargoRequest ToRequest(CrearCargoClientRequest clientRequest)
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
