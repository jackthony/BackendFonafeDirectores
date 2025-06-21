using Empresa.Application.EMP_Empresa.Dtos;
using Empresa.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.Presenters
{
    public class CrearEmpresaPresenter : IPresenter<
        CrearEmpresaClientRequest,
        CrearEmpresaRequest,
        SpResultBase,
        ItemResponse<int>>
    {
        public CrearEmpresaRequest ToRequest(CrearEmpresaClientRequest clientRequest)
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
