using Empresa.Application.Dtos;
using Empresa.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.Presenters
{
    public class EliminarEmpresaPresenter : IPresenter<
        EliminarEmpresaClientRequest,
        EliminarEmpresaRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public EliminarEmpresaRequest ToRequest(EliminarEmpresaClientRequest clientRequest)
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
