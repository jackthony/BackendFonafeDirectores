using Usuario.Application.Dtos;
using Usuario.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Usuario.Presentation.Presenters
{
    public class EliminarUsuarioPresenter : IPresenter<
        EliminarUsuarioClientRequest,
        EliminarUsuarioRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public EliminarUsuarioRequest ToRequest(EliminarUsuarioClientRequest clientRequest)
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
