using Ministerio.Application.Dtos;
using Ministerio.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Ministerio.Presentation.Presenters
{
    public class CrearMinisterioPresenter : IPresenter<
        CrearMinisterioClientRequest,
        CrearMinisterioRequest,
        SpResultBase,
        ItemResponse<int>>
    {
        public CrearMinisterioRequest ToRequest(CrearMinisterioClientRequest clientRequest)
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
