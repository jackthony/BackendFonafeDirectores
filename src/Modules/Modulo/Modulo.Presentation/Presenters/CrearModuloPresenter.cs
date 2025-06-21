using Modulo.Application.Dtos;
using Modulo.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Modulo.Presentation.Presenters
{
    public class CrearModuloPresenter : IPresenter<
        CrearModuloClientRequest,
        CrearModuloRequest,
        SpResultBase,
        ItemResponse<int>>
    {
        public CrearModuloRequest ToRequest(CrearModuloClientRequest clientRequest)
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
