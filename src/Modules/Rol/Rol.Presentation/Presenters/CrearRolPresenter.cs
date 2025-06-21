using Rol.Application.Dtos;
using Rol.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Rol.Presentation.Presenters
{
    public class CrearRolPresenter : IPresenter<
        CrearRolClientRequest,
        CrearRolRequest,
        SpResultBase,
        ItemResponse<int>>
    {
        public CrearRolRequest ToRequest(CrearRolClientRequest clientRequest)
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
