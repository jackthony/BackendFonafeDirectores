using Director.Application.Dtos;
using Director.Presentation.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Director.Presentation.Presenters
{
    public class CrearDirectorPresenter : IPresenter<
        CrearDirectorClientRequest,
        CrearDirectorRequest,
        SpResultBase,
        ItemResponse<int>>
    {
        public CrearDirectorRequest ToRequest(CrearDirectorClientRequest clientRequest)
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
