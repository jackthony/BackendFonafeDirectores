using Director.Application.Dtos;
using Director.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Director.Presentation.Presenters
{
    public class EliminarDirectorPresenter : IPresenter<
        EliminarDirectorClientRequest,
        EliminarDirectorRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public EliminarDirectorRequest ToRequest(EliminarDirectorClientRequest clientRequest)
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
