using TipoDirector.Application.Dtos;
using TipoDirector.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace TipoDirector.Presentation.Presenters
{
    public class EliminarTipoDirectorPresenter : IPresenter<
        EliminarTipoDirectorClientRequest,
        EliminarTipoDirectorRequest,
        SpResultBase,
        ItemResponse<bool>>
    {
        public EliminarTipoDirectorRequest ToRequest(EliminarTipoDirectorClientRequest clientRequest)
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
