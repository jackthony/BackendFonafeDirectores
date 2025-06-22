using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Presentation.EMP_Ministerio.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Ministerio.Presenters
{
    public class EliminarMinisterioPresenter : IPresenter<
    EliminarMinisterioClientRequest,
    EliminarMinisterioRequest,
    SpResultBase,
    ItemResponse<bool>>
    {
        public EliminarMinisterioRequest ToRequest(EliminarMinisterioClientRequest clientRequest)
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
