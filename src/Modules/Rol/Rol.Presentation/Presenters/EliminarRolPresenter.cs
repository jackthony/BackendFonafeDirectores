using Rol.Application.Dtos;
using Rol.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rol.Presentation.Presenters
{
    public class EliminarRolPresenter : IPresenter<
        EliminarRolClientRequest,
        EliminarRolRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public EliminarRolRequest ToRequest(EliminarRolClientRequest clientRequest)
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
