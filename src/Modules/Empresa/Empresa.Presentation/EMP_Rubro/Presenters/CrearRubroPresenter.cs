using Empresa.Application.EMP_Rubro.Dtos;
using Empresa.Presentation.EMP_Rubro.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Rubro.Presenters
{
    public class CrearRubroPresenter : IPresenter<
    CrearRubroClientRequest,
    CrearRubroRequest,
    SpResultBase,
    ItemResponse<int>>
    {
        public CrearRubroRequest ToRequest(CrearRubroClientRequest clientRequest)
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
