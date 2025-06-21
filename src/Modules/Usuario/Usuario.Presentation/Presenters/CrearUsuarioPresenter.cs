using Usuario.Application.Dtos;
using Usuario.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Usuario.Presentation.Presenters
{
    public class CrearUsuarioPresenter : IPresenter<
        CrearUsuarioClientRequest,
        CrearUsuarioRequest,
        SpResultBase,
        ItemResponse<int>>
    {
        public CrearUsuarioRequest ToRequest(CrearUsuarioClientRequest clientRequest)
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
