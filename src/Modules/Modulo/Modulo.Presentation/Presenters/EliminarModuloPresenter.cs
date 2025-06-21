using Modulo.Application.Dtos;
using Modulo.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Modulo.Presentation.Presenters
{
    public class EliminarModuloPresenter : IPresenter<
        EliminarModuloClientRequest,
        EliminarModuloRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public EliminarModuloRequest ToRequest(EliminarModuloClientRequest clientRequest)
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
