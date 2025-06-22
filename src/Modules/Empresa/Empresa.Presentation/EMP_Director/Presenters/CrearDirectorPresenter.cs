using Empresa.Application.EMP_Director.Dtos;
using Empresa.Presentation.EMP_Director.Dtos.Request;
using Shared.ClientV1;
using Shared.Kernel.Interfaces;
using Shared.Kernel.Responses;

namespace Empresa.Presentation.EMP_Director.Presenters
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
