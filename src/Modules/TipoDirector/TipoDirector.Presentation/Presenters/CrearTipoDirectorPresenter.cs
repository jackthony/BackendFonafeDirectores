using TipoDirector.Application.Dtos;
using TipoDirector.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace TipoDirector.Presentation.Presenters
{
    public class CrearTipoDirectorPresenter : IPresenter<
        CrearTipoDirectorClientRequest,
        CrearTipoDirectorRequest,
        SpResultBase,
        ItemResponse<int>>
    {
        public CrearTipoDirectorRequest ToRequest(CrearTipoDirectorClientRequest clientRequest)
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
