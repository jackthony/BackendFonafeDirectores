using Empresa.Application.EMP_Ministerio.Dtos;
using Empresa.Presentation.EMP_Ministerio.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Ministerio.Presenters
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
